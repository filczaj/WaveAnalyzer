﻿#pragma checksum "..\..\..\GUI\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6B0F8E6C24B531F883697C668D7697FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DynamicDataDisplay.Markers;
using DynamicDataDisplay.Markers.MarkerGenerators;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.Charts;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes.Numeric;
using Microsoft.Research.DynamicDataDisplay.Charts.Isolines;
using Microsoft.Research.DynamicDataDisplay.Charts.Maps;
using Microsoft.Research.DynamicDataDisplay.Charts.Maps.Network;
using Microsoft.Research.DynamicDataDisplay.Charts.Navigation;
using Microsoft.Research.DynamicDataDisplay.Charts.NewLine;
using Microsoft.Research.DynamicDataDisplay.Charts.Selectors;
using Microsoft.Research.DynamicDataDisplay.Charts.Shapes;
using Microsoft.Research.DynamicDataDisplay.Common.Palettes;
using Microsoft.Research.DynamicDataDisplay.Converters;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.Maps.Charts;
using Microsoft.Research.DynamicDataDisplay.Maps.Charts.TiledRendering;
using Microsoft.Research.DynamicDataDisplay.Maps.Charts.VectorFields.Streamlines;
using Microsoft.Research.DynamicDataDisplay.Maps.DeepZoom;
using Microsoft.Research.DynamicDataDisplay.Maps.Servers;
using Microsoft.Research.DynamicDataDisplay.Maps.Servers.FileServers;
using Microsoft.Research.DynamicDataDisplay.Maps.Servers.Network;
using Microsoft.Research.DynamicDataDisplay.Markers.MarkerGenerators.Rendering;
using Microsoft.Research.DynamicDataDisplay.MarkupExtensions;
using Microsoft.Research.DynamicDataDisplay.Navigation;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using Microsoft.Research.DynamicDataDisplay.ViewportConstraints;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace WaveAnalyzer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openFileButton;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fileNameBox;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playButton;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stopButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox framesBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bitrateBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox channelsBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button readButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox pitchListBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.ChartPlotter pitchPlotter;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.Charts.Axes.HorizontalIntegerAxis timeAxis;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pitchBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pitchHzBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\GUI\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button notesFinderButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WaveAnalyzer;component/gui/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GUI\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.openFileButton = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\GUI\MainWindow.xaml"
            this.openFileButton.Click += new System.Windows.RoutedEventHandler(this.openFileButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.fileNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.playButton = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\GUI\MainWindow.xaml"
            this.playButton.Click += new System.Windows.RoutedEventHandler(this.playButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.stopButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\GUI\MainWindow.xaml"
            this.stopButton.Click += new System.Windows.RoutedEventHandler(this.stopButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.framesBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.bitrateBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.channelsBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.readButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\GUI\MainWindow.xaml"
            this.readButton.Click += new System.Windows.RoutedEventHandler(this.readButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 18 "..\..\..\GUI\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.pitchListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 19 "..\..\..\GUI\MainWindow.xaml"
            this.pitchListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.pitchListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.pitchPlotter = ((Microsoft.Research.DynamicDataDisplay.ChartPlotter)(target));
            return;
            case 13:
            this.timeAxis = ((Microsoft.Research.DynamicDataDisplay.Charts.Axes.HorizontalIntegerAxis)(target));
            return;
            case 14:
            this.pitchBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.pitchHzBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.notesFinderButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\GUI\MainWindow.xaml"
            this.notesFinderButton.Click += new System.Windows.RoutedEventHandler(this.notesFinderButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

