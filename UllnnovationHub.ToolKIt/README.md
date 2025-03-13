# UllnnovationHub

一个寻求和分享设计灵感的开源WPF应用程序UI库

## 1.项目概述

UllnnovationHub，旨在寻求和分享WPF UI设计灵感。它提供了一些基础的WPF原生控件和自定义控件，未来还将继续加入更多的控件样式。

## 2.开发环境

Windows 11 + Visual Studio 2022 Enterprise+ .NET 6.0

## 3.使用方法

```xaml
1.编译UllnnovationHub.ToolKIt项目并生成UllnnovationHub.ToolKIt.dll
2.WPF项目添加对UllnnovationHub.ToolKIt.dll的引用，在然后App.xaml里添加如下代码以引用资源文件：
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/UllnnovationHub.ToolKIt;Component/Generic.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
3.//在xaml页面引用命名空间
  xmlns:UI="clr-namespace:UllnnovationHub.ToolKIt.UI;assembly=UllnnovationHub.ToolKIt"
4.//使用自定义控件或者样式
<UI:Card Margin="20"/>

<GroupBox Header="测试" Margin="10" Style="{StaticResource BaseGroupBoxStyle}"/>
<GroupBox Header="测试" Margin="10" Style="{StaticResource SqureShadowHeaderGroupBoxStyle}"/>
<GroupBox Header="测试" Margin="10" Style="{StaticResource RoundedShadowHeaderGroupBoxStyle}"/>
```



