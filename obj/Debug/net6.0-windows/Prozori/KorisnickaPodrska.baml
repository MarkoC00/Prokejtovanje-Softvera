   M S B A M L   `   `   `  ����E  ANISsoftver, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NISsoftver.ProzoriNISsoftver.Prozori  5   	   *    $NISsoftver.Prozori.KorisnickaPodrska   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NISsoftver.Prozori     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��500��5   	   $	��600��6     � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      � ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ #19499B��6    � Offset$ 0Q�6/   � 5      $ #5F91E8��6   $	 1.5Q�6/   5      	 � RowDefinitions	 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��90 �6   .+�5"   
   �� $��0��6   $��Korisnicka podrska��5#      $��Center=�5$      $��0 20 0 0q�5%      $
��Bold"�5&      $��30(�5'      
�������5(      �� 5)   
   
�������$��2q�5*      $��1��5+      
 �� CornerRadius$
 10��5,      $��10 40 10 10q�5-      ._�5.   
   � 	 5/      �� 50      $��* �6    �� 51      $
��Auto �6    .+�54      �� -   5         ��Name$ ChatListBox��54      $��0��55      $��10q�56      $
|�True��57      $
��True��58      $
��Auto=�59      ��5:      �� 5;       �� 
TargetType" ��6    .�5<      ��  �� Property �@J�IsHitTestVisible �� Value$ False��6A   5=      ��5?      �� 5@      .R�5A      �� 
�������$��5q�5C   $   ��5A   $   �� 5C   $   5D      5F      �� 5H      $��1��6    �� Orientation$ 
Horizontal=�6&   $��10q�6?   .+�5I      �� $
 10��6   $��2q�5J      
�������._�5L      �� -   5         ��Name$ MessageTextBox��5L   #   $	��450��5M   #   $��0q�5N   #   
�������$��0,0,30,0q�5P   #   5Q      �� 5R      -   5         ��Name$ Btn_Posalji��5S      $��Posalji��5R      ���#DD0713
�������+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10 10 10 10��5U      5V      5W      5X      5Y      �� 5\   
   -   5        $��2��5\      ���#DD0713
�������$��25(�5^      $��Povratak na login��6   $��55��5_      $	��250��5`      $��0,0,0,0q�5a      $ 	0 25 0 25��5b      5c      5e      5f      