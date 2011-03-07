﻿/*allinone合并了多个文件,下载使用多个allinone代码,可能会遇到重复的类型定义,可以下载对应的zip文件*/
// HACK: 如果代码不能编译, 请尝试设置为 V4, V3_5, V3, V2 以表示不同的 .NET 版本
#define V4
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;
// .class/ui/WindowCore.cs
/*
 * 参考文档: http://blog.sina.com.cn/s/blog_604c436d0100o07z.html (目前已经停止更新同步)
 * 如果您无法运行此文件, 可能由于缺少相关类文件, 请下载解决方案后重试, 具体请参考: http://blog.sina.com.cn/s/blog_604c436d0100o04s.html
 * 原始代码: http://zsharedcode.googlecode.com/svn/trunk/zsharedcode/panzer/.class/ui/WindowCore.cs
 * 引用代码:
 * http://zsharedcode.googlecode.com/svn/trunk/zsharedcode/panzer/.interface/ui/IWindow.cs
 * 测试文件:
 * http://zsharedcode.googlecode.com/svn/trunk/zsharedcode/panzer/test/ui/wc/TestWindowCore.cs
 * http://zsharedcode.googlecode.com/svn/trunk/zsharedcode/panzer/test/ui/wc/FormStudent.cs
 * http://zsharedcode.googlecode.com/svn/trunk/zsharedcode/panzer/test/ui/wc/FormStudent.Designer.cs
 * 合并下载:
 * http://zsharedcode.googlecode.com/svn/trunk/zsharedcode/panzer/.code/WindowCore.all.cs
 * 打包下载:
 * http://zsharedcode.googlecode.com/files/WindowCore.zip (目前已经停止更新同步)
 * http://zsharedcode.googlecode.com/files/WindowCore.with.test.zip (包含测试) (目前已经停止更新同步)
 * 版本: 2.0, .net 4.0, 其它版本可能有所不同
* */



namespace zoyobar.shared.panzer.ui
{

	#region " EventHandlerType "
	// TODO: (自定义) 可以为 EventHandlerType 添加新的类型.
	/// <summary>
	/// 与窗口或界面相关的事件类型.
	/// </summary>
	public enum EventHandlerType
	{
		/// <summary>
		/// 事件为 EventHandler.
		/// </summary>
		EventHandler = 1,
		/// <summary>
		/// 事件为 KeyEventHandler.
		/// </summary>
		KeyEventHandler = 2,
		/// <summary>
		/// 事件为 KeyPressEventHandler.
		/// </summary>
		KeyPressEventHandler = 3,
		/// <summary>
		/// 事件为 MouseEventHandler.
		/// </summary>
		MouseEventHandler = 4
	}
	#endregion

	/// <summary>
	/// WindowCore 是其它窗口或界面核心类的基类, 用于将控件布局和其实现的功能分离.
	/// </summary>
	/// <typeparam name="IW">界面实现的接口类型.</typeparam>
	public class WindowCore<IW>
		where IW : IWindow
	{
		protected Exception error;

		protected IW window;

		/// <summary>
		/// 创建窗口界面核心类.
		/// </summary>
		/// <param name="window">接口, 为核心类工作提供平台.</param>
		public WindowCore ( IW window )
		{

			if ( null == window || null == window.Platform )
				throw new ArgumentNullException ( "window", "平台与其 Platform 属性不能为空" );

			this.window = window;
		}

		protected EventInfo getEventInfo ( object target, Type type, string eventName )
		{

			if ( string.IsNullOrEmpty ( eventName ) )
				return null;

			if ( null != target )
				type = target.GetType ( );

			if ( null == type )
				return null;

			return type.GetEvent ( eventName );
		}

#if V3_5 || V4
		/// <summary>
		/// 绑定事件.
		/// </summary>
		/// <typeparam name="A">事件的 EventArgs 类型.</typeparam>
		/// <param name="target">将绑定的目标实例, 如果绑定静态事件, 可以为 null.</param>
		/// <param name="type">如果绑定静态事件, 可以指定类型.</param>
		/// <param name="eventName">事件的名称.</param>
		/// <param name="eventType">事件的类型.</param>
		/// <param name="handler">委托, 在事件触发时执行.</param>
		public void BindEvent<A> ( object target, Type type, string eventName, EventHandlerType eventType, Action<object, A> handler )
			where A : EventArgs
		{

			if ( null == handler )
				return;

			EventInfo eventInfo = this.getEventInfo ( target, type, eventName );

			if ( null == eventInfo )
				return;

			Delegate eventHandler;

			try
			{

				// TODO: (自定义) 当修改 EventHandlerType 时, 请在下面的 switch 中生成对应的事件.
				switch ( eventType )
				{
					case EventHandlerType.KeyEventHandler:
						eventHandler = new KeyEventHandler ( handler as Action<object, KeyEventArgs> );
						break;

					case EventHandlerType.KeyPressEventHandler:
						eventHandler = new KeyPressEventHandler ( handler as Action<object, KeyPressEventArgs> );
						break;

					case EventHandlerType.MouseEventHandler:
						eventHandler = new MouseEventHandler ( handler as Action<object, MouseEventArgs> );
						break;

					case EventHandlerType.EventHandler:
					default:
						eventHandler = new EventHandler ( handler as Action<object, EventArgs> );
						break;
				}

				eventInfo.AddEventHandler ( target, eventHandler );
			}
			catch { }

		}
#else
		/// <summary>
		/// 绑定事件.
		/// </summary>
		/// <typeparam name="A">事件的 EventArgs 类型.</typeparam>
		/// <param name="target">将绑定的目标实例, 如果绑定静态事件, 可以为 null.</param>
		/// <param name="type">如果绑定静态事件, 可以指定类型.</param>
		/// <param name="eventName">事件的名称.</param>
		/// <param name="eventType">事件的类型.</param>
		/// <param name="handler">委托, 在事件触发时执行.</param>
		public void BindEvent<A> ( object target, Type type, string eventName, EventHandlerType eventType, Delegate handler )
			where A : EventArgs
		{ throw new NotImplementedException ( ".NET 3.5 以下版本中方法尚未实现, 请切定义 V3_5 或者 V4, 并换到 3.5 或者 4 版本" ); }
#endif

	}

}
// .interface/ui/IWindow.cs
/*
 * 原始代码: http://zsharedcode.googlecode.com/svn/trunk/zsharedcode/panzer/.interface/ui/IWindow.cs
 * 版本: 2.0, .net 4.0, 其它版本可能有所不同
 * */


namespace zoyobar.shared.panzer.ui
{

	/// <summary>
	/// 实现 WindowCore 类工作平台的功能.
	/// </summary>
	public interface IWindow
	{

		/// <summary>
		/// 获取实现 IWindow 的对象.
		/// </summary>
		object Platform 
		{ get; }

	}

}