﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace ANH.RACOMS
{
    /// <summary>
    /// Match the label width of all text entry controls inside this panel
    /// </summary>
    public class TextEntryWidthMatcherProperty : BaseAttachedProperty<TextEntryWidthMatcherProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Get the panel (grid typically)
            var panel = (sender as Panel);

            // Call SetWidths initially (this also helps design time to work)
            SetWidths(panel);

            RoutedEventHandler onLoaded = null;
            // Wait for panel to load
            onLoaded += (s, ee) =>
            {
                // Unhook
                panel.Loaded -= onLoaded;

                // Set widths
                SetWidths(panel);

                // Loop each child
                foreach (var child in panel.Children)
                {
                    // Ignore any non-text entry controls
                    if (child is TextEntryControl)
                    {
                        // Set it's margin to the given value
                        ((TextEntryControl)child).Label.SizeChanged += (ss, eee) =>
                        {
                            // Update widths
                            SetWidths(panel);
                        };
                    }
                    else if (child is TextNumericControl)
                    {
                        // Set it's margin to the given value
                        ((TextNumericControl)child).Label.SizeChanged += (ss, eee) =>
                        {
                            // Update widths
                            SetWidths(panel);
                        };
                    }
                }
            };

            // Hook into the Loaded event
            panel.Loaded += onLoaded;
        }

        /// <summary>
        /// Update all child text entry controls so their widths match the largest width of the group
        /// </summary>
        /// <param name="panel">The panel containing the text entry controls</param>
        private void SetWidths(Panel panel)
        {
            // Keep track of the maximum width
            var maxSize = 0d;

            // For each child...
            foreach (var child in panel.Children)
            {
                // Ignore any non-text entry controls
                if (child is TextEntryControl control)
                { 
                    // Find if this value is larger than the other controls
                    maxSize = Math.Max(maxSize, control.Label.RenderSize.Width + control.Label.Margin.Left + control.Label.Margin.Right);
                }

                // Ignore any non-text numeric controls
                if (child is TextNumericControl ncontrol)
                {
                    // Find if this value is larger than the other controls
                    maxSize = Math.Max(maxSize, ncontrol.Label.RenderSize.Width + ncontrol.Label.Margin.Left + ncontrol.Label.Margin.Right);
                }
            }

            // Create a grid length converter
            var gridLength = (GridLength)new GridLengthConverter().ConvertFromString(maxSize.ToString());

            // For each child...
            foreach (var child in panel.Children)
            {
                // Ignore any non-text entry controls
                if (child is TextEntryControl control)
                {
                    // Find if this value is larger than the other controls
                    control.LabelWidth = gridLength;
                }

                // Ignore any non-text numeric controls
                if (child is TextNumericControl ncontrol)
                {
                    // Find if this value is larger than the other controls
                    ncontrol.LabelWidth = gridLength;
                }

            }
        }
    }
}