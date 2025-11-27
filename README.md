# UllnnovationHub

一个寻求和分享设计灵感的开源WPF应用程序UI库

![image-20241125105053177](README.assets/image-20241125105053177.png)

![image-20241125105122998](README.assets/image-20241125105122998.png)

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

## 4.项目简介

### 1.控件样式

包含了以下控件样式：

#### 1.Button

![image-20241125111213242](README.assets/image-20241125111213242.png)

#### 2.GroupBox

![image-20241125111226278](README.assets/image-20241125111226278.png)

#### 3.TabControl

![image-20241125111239285](README.assets/image-20241125111239285.png)

#### 4.RadioButton

![image-20241125111254966](README.assets/image-20241125111254966.png)

#### 5.SwitchButton

![image-20241125111306915](README.assets/image-20241125111306915.png)

#### 6.TextBox

![image-20241125111326262](README.assets/image-20241125111326262.png)

#### 7.PasswordBox

![image-20241125111340217](README.assets/image-20241125111340217.png)

#### 8.CheckBox

![image-20241125111354597](README.assets/image-20241125111354597.png)

#### 9.DateTimePicker

![image-20241125111412037](README.assets/image-20241125111412037.png)

#### 10.Expander

![image-20241125111601664](README.assets/image-20241125111601664.png)

#### 11.Card

![image-20241125111618710](README.assets/image-20241125111618710.png)

#### 12.ListBox

![image-20241125111636775](README.assets/image-20241125111636775.png)

#### 13.Treeview

![image-20241125111658308](README.assets/image-20241125111658308.png)

#### 14.Combox

![image-20241125111718950](README.assets/image-20241125111718950.png)

#### 15.Separator

![image-20241125111538281](README.assets/image-20241125111538281.png)

#### 16.ListView

#### 17.DataGrid

#### 18.Menu

#### 19.Slider

![image-20241125231545542](README.assets/image-20241125231545542.png)

#### 20.ScrollViewer

#### 21.ImageButton

![image-20241125231459043](README.assets/image-20241125231459043.png)



### 2.自定义控件种类

#### 1.DateTimePicker

![image-20241125111412037](README.assets/image-20241125111412037.png)

#### 2.Separator

![image-20241125111538281](README.assets/image-20241125111538281.png)

#### 3.Card

![image-20241125111618710](README.assets/image-20241125111618710.png)


## 5.参考资料

1. https://github.com/944095635/DMSkin
2. https://github.com/DinoChan/Kino.Toolkit.Wpf
3. https://github.com/JamesnetGroup/xamldesign.wpf

## 6.致谢

如果你觉得本框架还不错的话，欢迎赞助一杯咖啡

![](README.assets/wechat.png)

![](README.assets/ali.png)
