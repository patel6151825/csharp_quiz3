   M S B A M L   `   `   `  ����F  BWPFAppQuiz3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFAppQuiz3WPFAppQuiz3  5   	       WPFAppQuiz3.Task2Form   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFAppQuiz3     5   	   -   5          � Title$  Task 2��5   	   $	��400��6   $	��500��6%   .��5
      � .+�5   
   �� $��Students List��6   $��Center=�6(   $��20(�6E   
���  ��$��20q�6h   $
��Bold"�6t   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��stdDatagrid��5   g   $	��200��6   $
��Left=�6    $��	72,65,0,0q�6T      AutoGenerateColumns .     AlternatingRowBackground
 ����$	��Top=�6�   $	��350��6�   ��6;   ��    ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  �� Property � �� �� Value$
 Bold"�63   �� 5       � �� �#DC143C63   �� 5       � ��
 �����63   �� 5       � ��$ Georgia)�63   �� 5       � ��$ 40��6/   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Student ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 69   �� *Id+6P     5      $ 
First Name��6%   $	 * 6W   
 69   �� *	FirstName+6W     5      $ 	Last Name��6%   $	 * 6U   
 68   �� *
LastName+6U     5      $ Is Registered��6%   $	 * 6]   
 6<   �� *IsRegistered+6]   5      5      5      