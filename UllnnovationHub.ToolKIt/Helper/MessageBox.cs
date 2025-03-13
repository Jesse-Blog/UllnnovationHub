using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UllnnovationHub.ToolKIt.UI.UMessageBox;
using System.Windows;
using UllnnovationHub.ToolKIt.UI;

namespace UllnnovationHub.ToolKIt.Helper
{
	public class MessageBox
	{
		/// <summary>
		/// 显示消息框并返回用户的选择结果
		/// </summary>
		public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button = MessageBoxButton.OK)
		{
			ButtonType buttonType = ButtonType.OK;
			switch (button)
			{
				case MessageBoxButton.OK:
					buttonType = ButtonType.OK;
					break;
				case MessageBoxButton.OKCancel:
					buttonType = ButtonType.OKCancel;
					break;
				case MessageBoxButton.YesNo:
					buttonType = ButtonType.YesNo;
					break;
				case MessageBoxButton.YesNoCancel:
					buttonType = ButtonType.YesNoCancel;
					break;
			}
			
			UMessageBox window = new UMessageBox();
			return window.ShowAndGetResult(messageBoxText, caption, MessageBoxType.Info, buttonType);
		}

		/// <summary>
		/// 显示错误消息框并返回用户的选择结果
		/// </summary>
		public static MessageBoxResult Error(string messageBoxText, string caption)
		{
			UMessageBox window = new UMessageBox();
			return window.ShowAndGetResult(messageBoxText, caption, MessageBoxType.Error, ButtonType.OK);
		}

		/// <summary>
		/// 显示警告消息框并返回用户的选择结果
		/// </summary>
		public static MessageBoxResult Warning(string messageBoxText, string caption)
		{
			UMessageBox window = new UMessageBox();
			return window.ShowAndGetResult(messageBoxText, caption, MessageBoxType.Warning, ButtonType.OKCancel);
		}

		/// <summary>
		/// 显示询问消息框并返回用户的选择结果
		/// </summary>
		public static MessageBoxResult Question(string messageBoxText, string caption)
		{
			UMessageBox window = new UMessageBox();
			return window.ShowAndGetResult(messageBoxText, caption, MessageBoxType.Question, ButtonType.YesNo);
		}
	}

	#region 用法
//	// 示例用法
//var result = MessageBox.Show("用户信息更新成功！", "提示", MessageBoxButton.OKCancel);
//if (result == MessageBoxResult.OK)
//{
//    // 用户点击了"确定"按钮
//    // 执行相应的操作
//}
//else if (result == MessageBoxResult.Cancel)
//{
//	// 用户点击了"取消"按钮
//	// 执行相应的操作
//}

//// 其他示例
//var yesNoResult = MessageBox.Show("是否继续操作？", "确认", MessageBoxButton.YesNo);
//if (yesNoResult == MessageBoxResult.Yes)
//{
//	// 用户点击了"是"按钮
//}

//// 错误消息示例
//var errorResult = MessageBox.Error("操作失败，请重试", "错误");
//if (errorResult == MessageBoxResult.OK)
//{
//	// 用户确认了错误消息
//}

//// 警告消息示例
//var warningResult = MessageBox.Warning("此操作可能导致数据丢失", "警告");
//if (warningResult == MessageBoxResult.OK)
//{
//	// 用户确认了警告消息
//}

//// 询问消息示例
//var questionResult = MessageBox.Question("是否保存更改？", "询问");
//if (questionResult == MessageBoxResult.Yes)
//{
//	// 用户选择了"是"
//}
	#endregion
}
