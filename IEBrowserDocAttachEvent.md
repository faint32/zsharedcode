﻿#summary IEBrowser 为页面元素添加 .NET 事件
#labels Phase-Implementation
<font face='microsoft yahei'>
<font size='1'><a href='http://www.microsofttranslator.com/bv.aspx?from=&to=en&a=http://code.google.com/p/zsharedcode/wiki/IEBrowserDocAttachEvent'>Translate this page</a></font>

<h3>代码</h3>
<pre><code>// 需要引用 using zoyobar.shared.panzer.web;
// 需要引用 using zoyobar.shared.panzer.web.ib;

private void cmdAttachEvent_Click ( object sender, EventArgs e )
{
	// 从当前的 WebBrowser 控件创建 IEBrowser 对象.
	IEBrowser ie = new IEBrowser ( this.webBrowser );

	// 导航到页面 http://www.baidu.com/.
	ie.Navigate ( "http://www.baidu.com/" );

	// 等待页面载入完毕.
	ie.IEFlow.Wait ( new UrlCondition ( "wait", "http://www.baidu.com", StringCompareMode.StartWith ) );

	// 为页面上 id 为 kw 的文本框增加 onchange 事件.
	ie.AttachEventByID ( "kw", "onchange", this.kwOnChange );

	// 为页面所有超链接增加鼠标滑入事件.
	ie.AttachEventByTagName ( "a", "onmouseenter", this.aOnMouseEenter );

	// 安装 jQuery 脚本.
	ie.InstallJQuery(JQuery.CodeMin);

	// 使用 JQuery 对象为 id 为 su 的搜索按钮增加 onclick 事件.
	ie.AttachEventByJQuery ( JQuery.Create ( "'#su'" ), "onclick", this.suOnChange );
}

private void kwOnChange ( object sender, EventArgs e )
{
	// 获取触发事件的文本框.
	HtmlElement kw = sender as HtmlElement;

	// 显示文本框的值.
	Console.WriteLine ( "用户输入了: {0}", kw.GetAttribute("value") );
}

private void aOnMouseEenter ( object sender, EventArgs e )
{
	// 获取触发事件的超链接.
	HtmlElement a = sender as HtmlElement;

	// 显示超链接的消息.
	Console.WriteLine ( "用户鼠标滑过了: {0}", a.InnerText );
}

private void suOnChange ( object sender, EventArgs e )
{
	// 获取触发事件的按钮.
	HtmlElement su = sender as HtmlElement;

	// 显示点击消息.
	Console.WriteLine ( "用户点击了: {0}", su.GetAttribute ( "value" ) );
}
</code></pre>

<h3>说明</h3>
<blockquote>如果你希望在 .NET 中编写页面中元素的事件, 则可以使用 <a href='IEBrowser.md'>IEBrowser</a> 的 AttachEvent 系列的方法来实现.</blockquote>

<blockquote>AttachEvent 系列有 AttachEvent, AttachEventByID, AttachEventByTagName, AttachEventByJQuery 4 个方法, 分别可以为 HtmlElement 对象, 指定 id 或者 tagName 的元素, <a href='JQuery.md'>JQuery</a> 对象表示的元素添加 .NET 事件. 在这些方法中, 还需要指定事件的名称, 比如: "onclick", "onmouseenter" 等, 以及对应的 .NET 中的事件.</blockquote>

<blockquote>当使用了 AttachEvent 方法添加事件后, 可以使用对应的 DetachEvent 系列方法删除事件.</blockquote>

<blockquote><i>这里仅列出部分代码, 可能需要您自己创建窗口, 页面等.</i></blockquote>

<h3>使用</h3>
<blockquote>如果需要单独使用 <a href='IEBrowser.md'>IEBrowser</a>, 可以在 <a href='Download.md'>下载资源</a> 中的 IEBrowser.dll 下载一节下载 dll.</blockquote>

<blockquote>如果下载整个 <b>panzer</b> 项目, 请参考 <a href='HowToDownloadAndUse.md'>如何下载使用</a>.</blockquote>

<h3>需求</h3>
<blockquote>可能需要引用 System.Web 以及相关程序集.<br>
</font>