using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CaliburnM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /*
        Use MVVM with WPF - Caliburn Micro (NuGet) (Caliburn.Micro)

        // Getting Started
        // Change starting xaml page (Create MVVM, ShellViewModel and ShellView, Bootstrapper, change App.xaml)
        1. Folders  - Models, ViewModels, Views
        2. Class    - ShellViewModel : Screen // Later Screen is Conductor<object>
        3. Window   - ShellView
        4. Bootstrapper.cs - inherits from BootStrapperBase, Initilize in Ctor
            protected override OnStartup - DisplayRootViewFor<ShellViewModel>()
        5. App.xaml - remove StartupURI, Add <ResourceDictionary> for Bootstrapper
            <ResourceDictionary>
                <ResourceDictionary.MergedDictionaries>
                    <ResourceDictionary>
                        <local:Bootstrapper x:Key="Bootstrapper"/>

        Notes - 
            MVVM is all UI not business logic
            ShellView = mainpage replacement?
            Conductor<object> has more access - 
            Models      Data objects        
            ViewModels  Code for views      ShellViewModel
            Views       UI, textbox         ShellView

        // XAML
        //Top of window
        Title="MyTitle", FontSize="18"
        //Set columns and rows
        <Grid>
            grid.columndef
		        columndef width="20"
	        grid.rowdef
		        rowdef Height="20"
        // Elements set 1. Position 
                        2. Size  
                        3. Data
        <TextBlock	Grid.Column and Grid.Row, Grid.ColumnSpan, 
                    Margin, fontsize, 
                    text, actions
        <TextBox 	x:Name="nameTxt" 
        <Button 	x:Name="submitBtn Content="Hello"
        <ComboBox 	x:Name="myCBBox"
        <ComboBox 
		        ComboBox.ItemTemplate
			        <DataTemplate>
				        <TextBlock text="{Binding FirstName}"
        <Image 		Source="image1.jpg"
        <MediaElement	Source="video1.mp4"
        <StackPanel 	Orientation="Horizontal"
		        <Image MaxHeight/Width=200 Source="..\..\..\image1.jpg"
        <WrapPanel  	// Same as StackPanel
        <ScrollViewer	
		<StackPanel ...
        <ContentControl 


        // To name properties multiple times, call them directly
        <TextBlock      Text="{Binding Path=FullName, Mode=OneWay}"/>
        // Instead of 
        <TextBlock  x:Name="FirstName"/>

        // ComboBox display selected in TextBlock - 
        //      List of "People", Selected is "SelectedPerson", ComboBox text = "FirstName"
        //          TextBlock is "SelectedPerson_LastName" property of Person.LastName 
        <ComboBox x:Name="People"
                  SelectedItem="{Binding Path=SelectedPerson, Mode=OneWayToSource}"
                  DisplayMemberPath="FirstName"/>
        <TextBlock x:Name="SelectedPerson_LastName"/>
        */
    }
}
