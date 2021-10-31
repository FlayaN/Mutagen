using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Records;
using ReactiveUI;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Noggog;
using Noggog.WPF;

namespace Mutagen.Bethesda.WPF.Plugins
{
    [TemplatePart(Name = "PART_AddedFormKeyListBox", Type = typeof(ListBox))]
    public class FormKeyMultiPicker : AFormKeyPicker
    {
        private ListBox? _formKeyListBox;

        public ICollection<FormKey>? FormKeys
        {
            get => (ICollection<FormKey>)GetValue(FormKeysProperty);
            set => SetValue(FormKeysProperty, value);
        }
        public static readonly DependencyProperty FormKeysProperty = DependencyProperty.Register(nameof(FormKeys), typeof(ICollection<FormKey>), typeof(FormKeyMultiPicker),
             new FrameworkPropertyMetadata(default(ICollection<FormKey>?)));

        public FormKey? SelectedFormKey
        {
            get => (FormKey?)GetValue(SelectedFormKeyProperty);
            set => SetValue(SelectedFormKeyProperty, value);
        }
        public static readonly DependencyProperty SelectedFormKeyProperty = DependencyProperty.Register(nameof(SelectedFormKey), typeof(FormKey?), typeof(FormKeyMultiPicker),
             new FrameworkPropertyMetadata(default(FormKey?), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public Brush SelectedForegroundBrush
        {
            get => (Brush)GetValue(SelectedForegroundBrushProperty);
            set => SetValue(SelectedForegroundBrushProperty, value);
        }
        public static readonly DependencyProperty SelectedForegroundBrushProperty = DependencyProperty.Register(nameof(SelectedForegroundBrush), typeof(Brush), typeof(FormKeyMultiPicker),
             new FrameworkPropertyMetadata(Application.Current.Resources[Noggog.WPF.Brushes.Constants.SelectedForeground]));

        public ICommand AddFormKeyCommand
        {
            get => (ICommand)GetValue(AddFormKeyCommandProperty);
            set => SetValue(AddFormKeyCommandProperty, value);
        }
        public static readonly DependencyProperty AddFormKeyCommandProperty = DependencyProperty.Register(nameof(AddFormKeyCommand), typeof(ICommand), typeof(FormKeyMultiPicker),
             new FrameworkPropertyMetadata(default(ICommand), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public Brush ItemHoverBrush
        {
            get => (Brush)GetValue(ItemHoverBrushProperty);
            set => SetValue(ItemHoverBrushProperty, value);
        }
        public static readonly DependencyProperty ItemHoverBrushProperty = DependencyProperty.Register(nameof(ItemHoverBrush), typeof(Brush), typeof(FormKeyMultiPicker),
             new FrameworkPropertyMetadata(default(Brush), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public Brush SelectedBackgroundBrush
        {
            get => (Brush)GetValue(SelectedBackgroundBrushProperty);
            set => SetValue(SelectedBackgroundBrushProperty, value);
        }
        public static readonly DependencyProperty SelectedBackgroundBrushProperty = DependencyProperty.Register(nameof(SelectedBackgroundBrush), typeof(Brush), typeof(FormKeyMultiPicker),
             new FrameworkPropertyMetadata(Application.Current.Resources[Noggog.WPF.Brushes.Constants.SelectedBackground]));

        public ICommand DeleteSelectedItemsCommand
        {
            get => (ICommand)GetValue(DeleteSelectedItemsCommandProperty);
            set => SetValue(DeleteSelectedItemsCommandProperty, value);
        }
        public static readonly DependencyProperty DeleteSelectedItemsCommandProperty = DependencyProperty.Register(nameof(DeleteSelectedItemsCommand), typeof(ICommand), typeof(FormKeyMultiPicker),
             new FrameworkPropertyMetadata(default(ICommand), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        static FormKeyMultiPicker()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FormKeyMultiPicker), new FrameworkPropertyMetadata(typeof(FormKeyMultiPicker)));
            MissingMeansNullProperty.OverrideMetadata(typeof(FormKeyMultiPicker), new FrameworkPropertyMetadata(false));
        }

        public FormKeyMultiPicker()
        {
            PickerClickCommand = ReactiveCommand.Create((object o) =>
            {
                if (FormKeys == null) return;
                switch (o)
                {
                    case IMajorRecordIdentifier identifier:
                        FormKeys.Add(identifier.FormKey);
                        break;
                    default:
                        break;
                }
            });
            AddFormKeyCommand = ReactiveCommand.Create(
                canExecute: this.WhenAnyValue(x => x.FormKey)
                    .Select(x => !x.IsNull),
                execute: () =>
                {
                    if (FormKeys == null) return;
                    FormKeys.Add(FormKey);
                });
            DeleteSelectedItemsCommand = ReactiveCommand.Create(
                canExecute: this.WhenAnyValue(x => x.SelectedFormKey)
                    .Select(x => x != null),
                execute: () => _formKeyListBox?.TryRemoveSelected());
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _formKeyListBox = GetTemplateChild("PART_AddedFormKeyListBox") as ListBox;
            if (_formKeyListBox != null)
            {
                Noggog.WPF.Drag.ListBoxDragDrop(_formKeyListBox, () => this.FormKeys as IList<FormKey>)
                    .DisposeWith(_templateDisposable);
            }
        }
    }
}