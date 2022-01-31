using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace JPK_WysylkaXML.UI.Components
{
    public class NumericTextBox : TextBox
    {
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(double?), typeof(NumericTextBox), new PropertyMetadata(null));

        public static readonly DependencyProperty MaskProperty = DependencyProperty.Register("Mask", typeof(string), typeof(NumericTextBox), new PropertyMetadata("#0.00", OnMaskChanged));

        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            if ((SelectionLength == 0) && (e.Key == Key.Delete))
            {
                if ((SelectionLength == 0) && (SelectionStart < Text.Length - 1) && ((Text[SelectionStart] == ',') || (Text[SelectionStart] == '.')))
                    SelectionStart = SelectionStart + 1;

                base.OnPreviewKeyDown(e);
            }
            else if (e.Key == Key.Back)
            {
                if ((SelectionLength == 0) && (SelectionStart > 0) && ((Text[SelectionStart - 1] == ',') || (Text[SelectionStart - 1] == '.')))
                    SelectionStart = SelectionStart - 1;

                base.OnPreviewKeyDown(e);
            }
            else if (e.Key == Key.Space)
                e.Handled = true;
            else
                base.OnPreviewKeyDown(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Enter:
                case Key.Escape:
                    break;
                case Key.Decimal:
                case Key.OemComma:
                    if (Text.Contains(',') || Text.Contains('.'))
                    {
                        var commaPosition = Text.IndexOf(",", StringComparison.InvariantCulture) + 1;
                        SelectionStart = commaPosition;
                        e.Handled = true;
                    }
                    else
                        base.OnKeyDown(e);
                    break;

                case Key.Subtract:
                case Key.OemMinus:
                    if (Text.Contains('-'))
                        goto default;
                    goto case Key.D9;
                case Key.NumPad0:
                case Key.NumPad1:
                case Key.NumPad2:
                case Key.NumPad3:
                case Key.NumPad4:
                case Key.NumPad5:
                case Key.NumPad6:
                case Key.NumPad7:
                case Key.NumPad8:
                case Key.NumPad9:
                case Key.D0:
                case Key.D1:
                case Key.D2:
                case Key.D3:
                case Key.D4:
                case Key.D5:
                case Key.D6:
                case Key.D7:
                case Key.D8:
                case Key.D9:
                    base.OnKeyDown(e);
                    break;
                case Key.Tab:
                    base.OnKeyDown(e);
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Text) && Text.Contains("."))
            {
                Text = Text.Replace(".", ",");
                SelectionStart = Text.Length;
            }

            if (double.TryParse(Text, out var temp))
            {
                var tmpSelectionStart = SelectionStart;

                Value = temp;

                Text = Value.Value.ToString(Mask);

                SelectionStart = Text.Length >= tmpSelectionStart ? tmpSelectionStart : Text.Length;
            }
            else if (Text != "-" && Text != "")
            {
                Text = Value.ToString();
                Select(Text.Length, 0);
            }
            else
            {
                Value = null;
                base.OnTextChanged(e);
            }
        }

        private static void OnMaskChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (NumericTextBox)d;

            if (control.Text == string.Empty)
                return;

            control.Text = control.Value.HasValue ? control.Value.Value.ToString(control.Mask) : (0).ToString(control.Mask);
        }

        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonDown(e);

            if (!IsKeyboardFocusWithin)
            {
                e.Handled = true;

                Focus();
            }
        }

        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
        {
            base.OnGotKeyboardFocus(e);

            SelectionStart = 0;
            SelectionLength = Text.Length;
        }

        protected override void OnPreviewLostKeyboardFocus(KeyboardFocusChangedEventArgs e)
        {
            if (Text.Length > 1)
            {
                if (Text[Text.Length - 1] == ',')
                    Text = Text.Remove(Text.Length - 1);
            }

            base.OnPreviewLostKeyboardFocus(e);
        }

        public double? Value
        {
            get { return (double?)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public string Mask
        {
            get { return (string)GetValue(MaskProperty); }
            set { SetValue(MaskProperty, value); }
        }
    }
}