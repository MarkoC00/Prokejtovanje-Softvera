   M S B A M L   `   `   `  ����E  ANISsoftver, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:NISsoftver
NISsoftver  5   	       NISsoftver.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:NISsoftver     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $
��1080��5   	   $
��1920��6     � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#19499B � ColumnDefinitions 5      �� 5      $	��260 �6#   �� 5      $��* �6#   �� 5       $	��230 �6#   .+�5#      �� -   5        $��0��5#      $	��250��5$      $	��100��6!   
������ $��0q�5%   .   $
��Left=�5&      
 J� Uid$ 0��6B   .��5'      �� $��../Materijali/NISlogo.png��6   $
��Left=�6;   5(      �� 5+      $��1��6   	 �� Orientation$	 
Horizontal=�6)   $��Center=�5,      $��Center=�66   .+�5.      �� -   5        $��90��5.      $��90��6%   
������ $��0q�5/   2   
�������$
��20,0q�51      $ 1��69   .��52      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 	FireTruck=�6.   $��85��53   .   $��60��6:   $��Center=�54   .   $��Center=�55   .    � ToolTip 57      _� 58      $��
Vatrogasci��6"   5:      �� 5<      -   5        $��90��5<      $��90��6%   
������ $��0q�5=   2   
�������$
��20,0q�5?      $ 2��69   .��5@        $
 Hospital=�6.   $��85��5A   .   $	��875��6:   $��Center=�5B   .   $��Center=�5C   .    5E      _� 5F      $��Lekarski pregledi��6"   5H      �� 5J      -   5        $��90��5J      $��90��6%   
������ $��0q�5K   2   
�������$
��20,0q�5M      $ 3��69   .��5N        $
 AccountInjury=�6.   $��85��5O   .   $��60��6:   $��Center=�5P   .   $��Center=�5Q   .    5S      _� 5T      $��Povreda na radu��6"   5V      �� 5X      -   5        $��90��5X      $��90��6%   
������ $��0q�5Y   2   
�������$
��20,0q�5[      $ 4��69   .��5\        $
 NotebookEdit=�6.   $��85��5]   .   $��60��6:   $��Center=�5^   .   $��Center=�5_   .    5a      _� 5b      $ ��Pisanje tehničkog zadatka��6"   5d      �� 5f      -   5        $��90��5f      $��90��6%   
������ $��0q�5g   2   
�������$
��20,0q�5i      $ 5��69   .��5j        $
 Forum=�6.   $��85��5k   .   $��60��6:   $��Center=�5l   .   $��Center=�5m   .    5o      _� 5p      $��Poruke��6"   5r      �� 5s      -   5        $��90��5s      $��90��6%   
������ 
������ $��0q�5u      $��5q�5v      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Prijava greške��5w      .��5y        $
 AccountQuestionOutline=�6.   
�������$��85��5{   *   $��60��66   5|      5      �� 5�      $��2��6   $	 
Horizontal=�6)   $	��Top=�5�      $��Right=�6-   $��5q�5�      .+�5�      �� -   5        $��25��5�      $��25��6%   
������ 
������ $��0q�5�      $��5q�5�      $ Prijava greške��5�      .��5�        $
 Minus=�6.   $��Center=�5�   *   $��Center=�6E   
�������$��25��5�   *   $��25��66   5�      �� 5�      -	   5        $��25��5�      $��25��6%   
������ 
������ $��0q�5�      $��5q�5�      .��5�        $
 Close=�6.   $��Center=�5�   *   $��Center=�6E   
�������$��25��5�   *   $��25��66   5�      5�      � 5�      5�      5�      � 5�   
   -
   5         �Name$ GridUserContol��5�      $��1��6   .+�5�      �� -   5         ��Name$ mainContentControl��5�      5�      5�      5�      