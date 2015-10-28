﻿#summary JQueryElement 拖动效果
#labels Phase-Implementation
<font face='microsoft yahei'>
<font size='1'><a href='http://www.microsofttranslator.com/bv.aspx?from=&to=en&a=http://code.google.com/p/zsharedcode/wiki/JQueryElementDraggableDoc'>Translate this page</a></font>

<h3>简介</h3>
<blockquote>使用 JQueryElement 的 Draggable 控件即可实现 jQuery UI 中的拖动效果, 在最终的用户页面中, 可以使用鼠标拖动某些元素.</blockquote>

<h3>前提条件</h3>
<ol><li>请在 <a href='Download.md'>下载资源</a> 中的 JQueryElement.dll 下载一节下载 JQueryElement 3.0 或更高版本的 dll, 并为项目引用对应 .NET 版本的 dll.</li></ol>

<blockquote>2. 在页面添加如下指令:<br>
<pre><code>&lt;%@ Register Assembly="zoyobar.shared.panzer.JQueryElement" Namespace="zoyobar.shared.panzer.ui.jqueryui" TagPrefix="je" %&gt;
</code></pre></blockquote>

<blockquote>3. JQueryElement 并没有将 jQuery UI 的脚本和样式作为资源嵌入, 所以请将 jQuery UI 所需的脚本和样式复制到项目中并在页面中引用, 比如:<br>
<pre><code>&lt;script type="text/javascript" src="../js/jquery-1.5.1.min.js"&gt;&lt;/script&gt;
&lt;script type="text/javascript" src="../js/jquery-ui-1.8.11.custom.min.js"&gt;&lt;/script&gt;
&lt;link type="text/css" rel="Stylesheet" href="../css/smoothness/jquery-ui-1.8.15.custom.css" /&gt;
</code></pre></blockquote>

<blockquote>4. 添加如下 js 脚本:<br>
<pre><code>&lt;script type="text/javascript"&gt;
	function writeLine(selector, html) {
		$(selector).html($(selector).html() + html + '&lt;br /&gt;');
	}
&lt;/script&gt;
</code></pre></blockquote>

<blockquote>5. 页面包含如下自定义样式, 请参考文章尾部的 main.css.<br>
<pre><code>&lt;link type="text/css" rel="Stylesheet" href="../css/main.css" /&gt;
</code></pre></blockquote>

<h3>添加 ScriptPackage 控件</h3>
<blockquote>添加 ScriptPackage 控件, 用来统一存放控件产生的 js 脚本, 也可以不添加. 需要将控件放到页面代码的尾部, 否则有些 js 脚本可能不会被包含.<br>
<pre><code>&lt;je:ScriptPackage ID="package" runat="server" /&gt;
</code></pre></blockquote>

<h3>实现一个简单的拖动</h3>
<blockquote>在页面中添加如下代码:<br>
<pre><code>&lt;je:Draggable ID="dA" runat="server" CssClass="box" Html="&lt;strong&gt;可拖动 A&lt;/strong&gt;" ScriptPackageID="package"&gt;
&lt;/je:Draggable&gt;
</code></pre>
这里实现了一个可以拖动的元素, 其内部的 html 代码为 <code>&lt;strong&gt;可拖动 A&lt;/strong&gt;</code>, 其对应的 js 脚本将生成到刚才添加的 ScriptPackage 控件中.</blockquote>

<h3>通过选择器实现拖动</h3>
<blockquote>Draggable 可以使页面上其它的元素实现拖动效果, 通过 Selector 属性, 将其设置为一个选择器, 比如: <code>'#spanB'</code>, 表示选择页面中 id 为 spanB 的元素, 注意使用了单引号, 那么 spanB 将具有拖动效果.<br>
<pre><code>&lt;span id="spanB" class="box"&gt;可拖动 B, 不带有 jQuery UI 样式&lt;/span&gt;
&lt;je:Draggable ID="dB" runat="server" Selector="'#spanB'" AddClasses="False" ScriptPackageID="package"&gt;
&lt;/je:Draggable&gt;
</code></pre></blockquote>

<h3>效果说明</h3>
<blockquote>通过设置 Draggable 的属性实现的部分效果如下, 具体请参考 draggable.aspx:<br>
</blockquote><ul><li>拖动但不使用 jQuery UI 样式<br>
</li><li>限制沿 x/y 轴方向拖动<br>
</li><li>在为多个元素设置拖动效果时, 取消其中部分元素的拖动效果<br>
</li><li>拖动范围限制在某个容器中<br>
</li><li>拖动时显示特定的鼠标样式<br>
</li><li>拖动时鼠标的位置<br>
</li><li>限制鼠标按下一段时间或移动一段距离后产生拖动效果<br>
</li><li>拖动时按照点阵移动<br>
</li><li>鼠标按下元素内的某个元素时才产生拖动效果<br>
</li><li>拖动具有拖影<br>
</li><li>拖动具有透明度<br>
</li><li>拖动后恢复到起始位置<br>
</li><li>拖动的元素可附着到其它元素</li></ul>

<h3>事件说明</h3>
<blockquote>Draggable 控件具有如下事件, 具体请参考 draggable.aspx:<br>
</blockquote><ul><li>创建时<br>
</li><li>拖动开始时<br>
</li><li>拖动中<br>
</li><li>拖动结束时</li></ul>

<h3>draggable.aspx</h3>
<pre><code>&lt;%@ Page Language="C#" %&gt;

&lt;%@ Register Assembly="zoyobar.shared.panzer.JQueryElement" Namespace="zoyobar.shared.panzer.ui.jqueryui"
	TagPrefix="je" %&gt;
&lt;!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"&gt;
&lt;html xmlns="http://www.w3.org/1999/xhtml"&gt;
&lt;head runat="server"&gt;
	&lt;title&gt;JQuery UI 的拖动效果&lt;/title&gt;
	&lt;script type="text/javascript" src="../js/jquery-1.5.1.min.js"&gt;&lt;/script&gt;
	&lt;script type="text/javascript" src="../js/jquery-ui-1.8.11.custom.min.js"&gt;&lt;/script&gt;
	&lt;link type="text/css" rel="Stylesheet" href="../css/smoothness/jquery-ui-1.8.15.custom.css" /&gt;
	&lt;link type="text/css" rel="Stylesheet" href="../css/main.css" /&gt;
	&lt;script type="text/javascript"&gt;
		function writeLine(selector, html) {
			$(selector).html($(selector).html() + html + '&lt;br /&gt;');
		}
	&lt;/script&gt;
&lt;/head&gt;
&lt;body&gt;
	&lt;form id="formDraggable" runat="server"&gt;
	&lt;je:Draggable ID="dA" runat="server" CssClass="box" Html="&lt;strong&gt;可拖动 A&lt;/strong&gt;"
		ScriptPackageID="package"&gt;
	&lt;/je:Draggable&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;-&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;span id="spanB" class="box"&gt;可拖动 B, 不带有 jQuery UI 样式&lt;/span&gt;
	&lt;je:Draggable ID="dB" runat="server" Selector="'#spanB'" AddClasses="False" ScriptPackageID="package"&gt;
	&lt;/je:Draggable&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;AddClasses="False"&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;je:Draggable ID="dC" runat="server" CssClass="box" Axis="x" Text="可拖动 C, 沿 x 轴方向"
		ScriptPackageID="package"&gt;
	&lt;/je:Draggable&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;Axis="x"&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;p id="pD" class="panel" style="width: 80%; height: 50px;"&gt;
		&lt;span&gt;可拖动 D1&lt;/span&gt; &lt;span class="box"&gt;不可拖动 D2, 取消了样式为 box 的 span 元素的拖动&lt;/span&gt;
		&lt;je:Draggable ID="dD" runat="server" Selector="'#pD &gt; span'" ScriptPackageID="package"
			Cancel=".box"&gt;
		&lt;/je:Draggable&gt;
	&lt;/p&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;Selector="'#pD &gt; span'" Cancel=".box"&lt;/span&gt;
	&lt;br /&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;p class="panel" style="width: 80%; height: 50px;"&gt;
		&lt;je:Draggable ID="dE" runat="server" CssClass="box" Text="可拖动 E, 在 p 元素范围内" ScriptPackageID="package"
			Containment="parent"&gt;
		&lt;/je:Draggable&gt;
	&lt;/p&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;Containment="parent"&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;je:Draggable ID="dF" runat="server" CssClass="box" Text="可拖动 F, 拖动显示十字鼠标" ScriptPackageID="package"
		Cursor="crosshair"&gt;
	&lt;/je:Draggable&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;Cursor="crosshair"&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;je:Draggable ID="dG" runat="server" CssClass="box" Text="可拖动 G, 拖动时鼠标位于左上角偏移 50px"
		ScriptPackageID="package" CursorAt="{top: 50, left: 50}" Height="100px" Width="100px"&gt;
	&lt;/je:Draggable&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;CursorAt="{top: 50, left: 50}"&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;je:Draggable ID="dH" runat="server" CssClass="box" Text="可拖动 H, 鼠标按下 1 秒后产生拖动" ScriptPackageID="package"
		Delay="1000"&gt;
	&lt;/je:Draggable&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;Delay="1000"&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;je:Draggable ID="dI" runat="server" CssClass="box" Text="可拖动 I, 鼠标按下并移动 100px 后产生拖动"
		ScriptPackageID="package" Distance="100"&gt;
	&lt;/je:Draggable&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;Distance="100"&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;je:Draggable ID="dJ" runat="server" CssClass="box" Text="可拖动 J, 按照 10*10 的点阵移动"
		ScriptPackageID="package" Grid="[10, 10]"&gt;
	&lt;/je:Draggable&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;Grid="[10, 10]"&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;div id="wK" class="panel"&gt;
		&lt;div id="tK" class="box"&gt;
			标题 K
		&lt;/div&gt;
		&lt;div&gt;
			&lt;br /&gt;
			&lt;br /&gt;
			可拖动 K, 需要拖动标题 K
			&lt;br /&gt;
			&lt;br /&gt;
		&lt;/div&gt;
	&lt;/div&gt;
	&lt;je:Draggable ID="dK" runat="server" ScriptPackageID="package" Handle="#tK" Selector="'#wK'"&gt;
	&lt;/je:Draggable&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;Handle="#tK"&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;je:Draggable ID="dL" runat="server" CssClass="box" Text="可拖动 L, 有拖影和 50% 的透明度, 并播放恢复动画"
		ScriptPackageID="package" Helper="clone" Revert="True" Opacity="0.5" RevertDuration="1000"&gt;
	&lt;/je:Draggable&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;Helper="clone" Revert="True" Opacity="0.5" RevertDuration="1000"&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;je:Draggable ID="dM" runat="server" CssClass="box" Text="可拖动 M, 可与其它元素附着, 距离 30 px"
		ScriptPackageID="package" Snap="True" SnapTolerance="30"&gt;
	&lt;/je:Draggable&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;Snap="True" SnapMode="inner" SnapTolerance="30"&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;je:Draggable ID="dN" runat="server" CssClass="box" Text="可拖动 N, 事件"
		ScriptPackageID="package" Create="function(){writeLine('#pN', '创建');}" Drag="function(){writeLine('#pN', '拖动中');}"
		Start="function(){writeLine('#pN', '开始拖动');}" Stop="function(){writeLine('#pN', '结束拖动');}"&gt;
	&lt;/je:Draggable&gt;
	&lt;p id="pN" class="panel" style="width: 80%;"&gt;
	&lt;/p&gt;
	&lt;br /&gt;
	&lt;span class="code"&gt;Create="..." Drag="..." Start="..." Stop="..."&lt;/span&gt;
	&lt;br /&gt;
	&lt;hr /&gt;
	&lt;je:ScriptPackage ID="package" runat="server" /&gt;
	&lt;/form&gt;
&lt;/body&gt;
&lt;/html&gt;
</code></pre>

<h3>main.css</h3>
<pre><code>body
{
	font-family: "微软雅黑";
	font-size: 9pt;
}
hr
{
	border: solid 1px #eeeeee;
	margin-bottom: 50px;
}
li
{
	padding: 5px;
}
.panel
{
	border: solid 1px #cccccc;
	padding: 10px;
	background-color: #eeeeee;
}
.box
{
	border: solid 1px #999999;
	padding: 2px 5px 2px 5px;
	color: InfoText;
	background-color: InfoBackground;
}
.code
{
	float: right;
	font-style: italic;
	font-size: x-small;
	color: Blue;
}
.ui-selecting
{
	color: MenuText;
	background-color: InactiveCaption;
}
.ui-selected
{
	color: MenuText;
	background-color: ActiveCaption;
}
</code></pre>

<blockquote><i>这里仅列出部分代码, 可能需要您自己创建窗口, 页面等.</i>
</font>