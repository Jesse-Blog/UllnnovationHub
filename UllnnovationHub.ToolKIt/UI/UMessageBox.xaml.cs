using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using UllnnovationHub.ToolKIt.Attached;
using UllnnovationHub.ToolKIt.UI;
using System.Threading;
using System.Threading.Tasks;

namespace UllnnovationHub.ToolKIt.UI
{
	/// <summary>
	/// MessageBoxWindow.xaml 的交互逻辑
	/// </summary>
	public partial class UMessageBox : Window
	{
		public enum MessageBoxType
		{
			Info,
			Error,
			Warning,
			Question
		}

		public enum ButtonType
		{
			OK,
			OKCancel,
			YesNo,
			YesNoCancel
		}

		private ButtonType currentButtonStyle;
		private Action<MessageBoxResult> resultAction;
		private TaskCompletionSource<MessageBoxResult> resultTaskSource;

		public UMessageBox()
		{
			InitializeComponent();
			foreach (Window item in Application.Current.Windows)
			{
				if (item.IsActive)
				{
					Owner = item;
					break;
				}
			}
		}

		private void Confirm_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result;
			switch (currentButtonStyle)
			{
				case ButtonType.YesNo:
				case ButtonType.YesNoCancel:
					result = MessageBoxResult.Yes;
					break;
				default:
					result = MessageBoxResult.OK;
					break;
			}

			this.Close();
			resultAction?.Invoke(result);
			resultTaskSource?.SetResult(result);
		}

		private void Cancel_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result;
			switch (currentButtonStyle)
			{
				case ButtonType.YesNo:
					result = MessageBoxResult.No;
					break;
				default:
					result = MessageBoxResult.Cancel;
					break;
			}

			this.Close();
			resultAction?.Invoke(result);
			resultTaskSource?.SetResult(result);
		}

		private void No_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBoxResult.No;
			this.Close();
			resultAction?.Invoke(result);
			resultTaskSource?.SetResult(result);
		}

		public void Show(string messageBoxText, string caption, MessageBoxType type = MessageBoxType.Info, ButtonType buttonType = ButtonType.OK, Action<MessageBoxResult> callback = null)
		{
			this.Content.Text = messageBoxText;
			this.tB_Title.Text = caption;
			this.currentButtonStyle = buttonType;

			// 设置按钮样式和文本
			switch (buttonType)
			{
				case ButtonType.OK:
					Confirm.Content = "确定";
					Confirm.Visibility = Visibility.Visible;
					Cancel.Visibility = Visibility.Collapsed;
					No.Visibility = Visibility.Collapsed;
					break;

				case ButtonType.OKCancel:
					Confirm.Content = "确定";
					Cancel.Content = "取消";
					Confirm.Visibility = Visibility.Visible;
					Cancel.Visibility = Visibility.Visible;
					No.Visibility = Visibility.Collapsed;
					break;

				case ButtonType.YesNo:
					Confirm.Content = "是";
					Cancel.Content = "否";
					Confirm.Visibility = Visibility.Visible;
					Cancel.Visibility = Visibility.Visible;
					No.Visibility = Visibility.Collapsed;
					break;

				case ButtonType.YesNoCancel:
					Confirm.Content = "是";
					No.Content = "否";
					Cancel.Content = "取消";
					Confirm.Visibility = Visibility.Visible;
					No.Visibility = Visibility.Visible;
					Cancel.Visibility = Visibility.Visible;
					break;
			}

			this.resultAction = callback;
			
			// 设置窗口类型样式
			switch (type)
			{
				case MessageBoxType.Info:
					// 蓝色主题
					break;
				case MessageBoxType.Error:
					// 红色主题
					break;
				case MessageBoxType.Warning:
					// 黄色主题
					break;
				case MessageBoxType.Question:
					// 绿色主题
					break;
			}
			
			this.ShowDialog();
		}

		/// <summary>
		/// 显示消息框并返回结果
		/// </summary>
		public MessageBoxResult ShowAndGetResult(string messageBoxText, string caption, MessageBoxType type = MessageBoxType.Info, ButtonType buttonType = ButtonType.OK)
		{
			resultTaskSource = new TaskCompletionSource<MessageBoxResult>();
			
			this.Content.Text = messageBoxText;
			this.tB_Title.Text = caption;
			this.currentButtonStyle = buttonType;

			// 设置按钮样式和文本
			switch (buttonType)
			{
				case ButtonType.OK:
					Confirm.Content = "确定";
					Confirm.Visibility = Visibility.Visible;
					Cancel.Visibility = Visibility.Collapsed;
					No.Visibility = Visibility.Collapsed;
					break;

				case ButtonType.OKCancel:
					Confirm.Content = "确定";
					Cancel.Content = "取消";
					Confirm.Visibility = Visibility.Visible;
					Cancel.Visibility = Visibility.Visible;
					No.Visibility = Visibility.Collapsed;
					break;

				case ButtonType.YesNo:
					Confirm.Content = "是";
					Cancel.Content = "否";
					Confirm.Visibility = Visibility.Visible;
					Cancel.Visibility = Visibility.Visible;
					No.Visibility = Visibility.Collapsed;
					break;

				case ButtonType.YesNoCancel:
					Confirm.Content = "是";
					No.Content = "否";
					Cancel.Content = "取消";
					Confirm.Visibility = Visibility.Visible;
					No.Visibility = Visibility.Visible;
					Cancel.Visibility = Visibility.Visible;
					break;
			}
			
			// 设置窗口类型样式
			switch (type)
			{
				case MessageBoxType.Info:
					// 蓝色主题
					break;
				case MessageBoxType.Error:
					// 红色主题
					break;
				case MessageBoxType.Warning:
					// 黄色主题
					break;
				case MessageBoxType.Question:
					// 绿色主题
					break;
			}
			
			this.ShowDialog();
			
			// 如果窗口关闭但没有设置结果，则返回None
			if (resultTaskSource.Task.IsCompleted)
			{
				return resultTaskSource.Task.Result;
			}
			else
			{
				return MessageBoxResult.None;
			}
		}

		private void btn_Close_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBoxResult.None;
			this.Close();
			resultAction?.Invoke(result);
			resultTaskSource?.SetResult(result);
		}

		private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ButtonState == MouseButtonState.Pressed)
			{
				this.DragMove();
			}
		}
	}
}