using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;

namespace Ribbon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    /// <summary>
    /// IconTemplateSelector class for RibbonButton
    /// </summary>
    public class RibbonButtonIconTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SmallTemplate { get; set; }
        public DataTemplate LargeTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var item1 = (container as ContentPresenter);
            RibbonButton ribbonButton = (item1.TemplatedParent as RibbonButton);
            if (ribbonButton != null)
            {
                if (ribbonButton.SizeForm == SizeForm.Small || ribbonButton.SizeForm == SizeForm.ExtraSmall)
                {
                    return SmallTemplate;
                }
                else if (ribbonButton.SizeForm == SizeForm.Large)
                {
                    return LargeTemplate;
                }
            }
            return LargeTemplate;
        }
    }

    /// <summary>
    /// IconTemplateSelector class for DropDownButton
    /// </summary>
    public class DropDownButtonIconTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SmallTemplate { get; set; }
        public DataTemplate LargeTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var item1 = (container as ContentPresenter);
            DropDownButton dropDownButton = (item1.TemplatedParent as DropDownButton);
            if (dropDownButton != null)
            {
                if (dropDownButton.SizeForm == SizeForm.Small || dropDownButton.SizeForm == SizeForm.ExtraSmall)
                {
                    return SmallTemplate;
                }
                else if (dropDownButton.SizeForm == SizeForm.Large)
                {
                    return LargeTemplate;
                }
            }
            return LargeTemplate;
        }
    }

    /// <summary>
    /// IconTemplateSelector class for SplitButton
    /// </summary>
    public class SplitButtonIconTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SmallTemplate { get; set; }
        public DataTemplate LargeTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var item1 = (container as ContentPresenter);
            SplitButton splitButton = (item1.TemplatedParent as SplitButton);
            if (splitButton != null)
            {
                if (splitButton.SizeForm == SizeForm.Small || splitButton.SizeForm == SizeForm.ExtraSmall)
                {
                    return SmallTemplate;
                }
                else if (splitButton.SizeForm == SizeForm.Large)
                {
                    return LargeTemplate;
                }
            }
            return LargeTemplate;
        }
    }

    /// <summary>
    /// IconTemplateSelector class for RibbonGallery
    /// </summary>
    public class RibbonGalleryIconTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SmallTemplate { get; set; }
        public DataTemplate LargeTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var item1 = (container as ContentPresenter);
            RibbonGallery ribbonGallery = (item1.TemplatedParent as RibbonGallery);
            if (ribbonGallery != null)
            {
                if (ribbonGallery.SizeForm == SizeForm.Small || ribbonGallery.SizeForm == SizeForm.ExtraSmall)
                {
                    return SmallTemplate;
                }
                else if (ribbonGallery.SizeForm == SizeForm.Large)
                {
                    return LargeTemplate;
                }
            }
            return LargeTemplate;
        }
    }
}
