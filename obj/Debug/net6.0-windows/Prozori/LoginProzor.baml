   M S B A M L   `   `   `  ����E  ANISsoftver, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NISsoftver.ProzoriNISsoftver.Prozori  5   	   $    NISsoftver.Prozori.LoginProzor   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NISsoftver.Prozori     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��700��5   	   $	��600��6     � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      � ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ #19499B��6    � Offset$ 0Q�6/   � 5      $ #5F91E8��6   $	 1.5Q�6/   5      .+�5   
   �� $#��../Materijali/NISlogobeli.png��6   $��Uniform=�67   $	��300��5      $	��300��6   $	��Top=�5      �� 5   
   	 �� Orientation$	 
Horizontal=�6   $	��Top=�5       $��Right=�6-   $��5q�5!      .+�5"      �� -   5        $��35��5"      $��35��6!   
������ 
������ $��0q�5$      $��5q�5%      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Prijava greške��5&      .��5(      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AccountQuestionOutline=�6*   
�������$��35��5*   *   $��35��66   5+      �� 5,      -   5        $��35��5,      $��35��6!   
������ 
������ $��0q�5.      $��5q�50      .��51        $ Close=�6*   $��Center=�52   *   $��Center=�6E   
�������$��35��54   *   $��35��66   55      58      � 59   
   $��Bottom=�6   $��	0,0,0,230q�6*   $	��150��5:      .+�5;      ��  �� CornerRadius$ 15��6   $��3q�6'   
�������$��420px��5<      $��65��6#   $	��Top=�6/   ._�5=      �� -   5         ��Name$ Input_KorisnickoIme��5=       ! MaterialDesignOutlinedTextBox#��[ 5>      $��420px��5?      $��65��6$   $	��Top=�5@      $��Center=�6.   $��22(�5A      $��0q�5B      
�������$��SemiBold"�5C   .   $��Korisničko ime��5D      6,   5E      �� 5F      $ 15��6   $��3q�6'   
�������$��420px��5G      $��65��6#   $��Bottom=�6/   ._�5H      G� -   5         G�Name$ Input_Sifra��5H       + 'MaterialDesignOutlinedRevealPasswordBox#��[ 5I         FloatingOffset$ 0, -35&�5J      $��420px��5K      $��65��6$   $	��Top=�5L      $��Center=�6.   $��22(�5M      $��0q�5N      
�������$��SemiBold"�5O   .   $
 Unesite lozinku��5P      5Q      5U      � 5V   
   $��Bottom=�6   $��Center=�6*   .+�5W      �� -   5        ���#DD0713
�������$��25(�5X      $��	ULOGUJ SE��6'   $��55��5Y      $	��220��6%   $��0,0,0,60q�5Z      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 	0 25 0 25��5[      5\      �� 5_      -   5         ��Name$ ZaboravljenaLozinkaDugme��5`      $��40��5_      $	��220��6!   $��Bottom=�5b      
������ 
�������$��0q�5e      $��Zaboravili ste lozinku?��5f      $��18(�5g      $��10q�5h      5j      5k      5l      5m      