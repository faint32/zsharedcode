﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.239
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace zoyobar.shared.panzer.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("zoyobar.shared.panzer.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 (function(d){d.panzer={check:function(b,a,f){if(null==a)return b;null!=a.readonly&amp;&amp;a.readonly&amp;&amp;null!=f&amp;&amp;f&amp;&amp;d.error((null==a.name?&quot;argument&quot;:a.name)+&quot; is read-only&quot;);if(null!=a.allowNull&amp;&amp;!a.allowNull&amp;&amp;null==b)null==a.defaultValue?d.error((null==a.name?&quot;argument&quot;:a.name)+&quot; can not be empty&quot;):b=a.defaultValue;if(null!=a.type&amp;&amp;null!=b&amp;&amp;typeof b!=a.type)null==a.defaultValue?d.error((null==a.name?&quot;argument&quot;:a.name)+&quot; should be a &quot;+a.type):b=a.defaultValue;if(null!=a.allowSmall0&amp;&amp;!a.allowSmall0&amp;&amp;null!=
        ///b&amp;&amp;b&lt;0)nul [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string panzer_min {
            get {
                return ResourceManager.GetString("panzer_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (function(g){function v(b,a){var c=b.option;if(c.singlethread&amp;&amp;c.busy)return null!=c.blocked&amp;&amp;c.blocked.call(this,b,{action:a}),!1;c.busy=!0;if(null!=c.preexecute){var d={action:a,tip:null};c.preexecute.call(this,b,d);J.call(this,b,d.tip)}return!0}function P(b,a){if(B.call(this,b,a,&quot;state&quot;)!=&quot;removed&quot;){var c=b.option;!c.multipleedit&amp;&amp;null!=c.index.edit&amp;&amp;p.call(this,b,c.index.edit,&quot;editing&quot;,!1);c.index.edit=a;p.call(this,b,a,&quot;editing&quot;,!0);l.call(this,b,c.data)}}function l(b,a){var c=b.option,d=!1;
        ///c.data=a;c [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string repeater_min {
            get {
                return ResourceManager.GetString("repeater_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (function(b){function c(a){a=a.option;a.count=0;null!=a.handler&amp;&amp;clearInterval(a.handler)}b.fn.timer=function(){var a=b.panzer.getPE.call(this,&quot;timer&quot;,arguments);return null==a?this:a.result};b.fn.timer.funs={destroy:{method:function(a){c.call(this,a);b.panzer.destroy.call(this,a)}},start:{method:function(a){c.call(this,a);var b=a.option;b.handler=setInterval(function(){b.count++;null!=b.tick&amp;&amp;b.tick.call(this,a,{count:b.count})},b.interval)}},stop:{method:c}};b.fn.timer.defaults={count:0,handler:null,
        ///inte [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string timer_min {
            get {
                return ResourceManager.GetString("timer_min", resourceCulture);
            }
        }
    }
}
