   M S B A M L   `   `   `  ����N  JManageCategoriesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ManageCategoriesAppManageCategoriesApp  5   	   $    ManageCategoriesApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ManageCategoriesApp     5   	   -   5          � Title$  Manga Categories��5   	   $	��430��6"   $	��420��6/    � WindowStartupLocation$ CenterScreen=�5	       � 
ResizeMode$ NoResize=�6C   .��5      �  � RowDefinitions 5      �� 5      $��* �6   �� 5      $��* �6   .+�5      �� 
����ح� �� Orientation$ Vertical=�6+   $
��Left=�5      $	��400��64   .+�5      �� -   5        $��lblInstruction��5      
���  ��$��DemiBold"�68   $��20(�5      $��Category Information��6"   �� 5      -   5        $��lblCategoryID��5      $��
CategoryID��6&   �� 5      -   5        $��txtCategoryID��5      $
��Left=�6(    �� 
IsReadOnly$
 True��5      $��25��6(   $	��300��64   ��5      ��  �� Path$ 
CategoryID� �� Mode$ OneWay=� � DataContext 5      �� 	 �� ElementName$	 lvCategories��$ SelectedItem��� 5      -   5        $��lbCategoryName��5      $��Category Name��6'   �� 5      -   5        $��txtCategoryName��5      $
��Left=�6*   $��25��5      $	��300��6"   ��6/   �� $ CategoryName�$ OneWay=� 5      �� $	 lvCategories��$ SelectedItem��� 5       $ 
Horizontal=�6   $
��Left=�60   .+�5!      �� -   5        
 ��Name$
 	btnInsert��5!      $��10q�6(   $��80��64   $��Insert��6?   5"      �� 5#      -   5        $
 	btnUpdate��5#      $��10q�6)   $��80��65   $��Update��6A   5$      �� 5%      -	   5        $
 	btnDelete��5%      $��10q�6(   $��80��65   $��Delete��6@   5&      5'      5(   	   �� 5)      -
   5        $��lvCategories��5)      $��1��6   $	��400��62    �� View 5*      �� 5+      .P�5,      �� $��Category ID��6     �� Width$	 100��66    �� DisplayMemberBinding 5-   %   �� $ 
CategoryID��� 5.      $��Category Name��6    $	 200��67    5/   %   �� $ CategoryName�50      52   	   56      57      