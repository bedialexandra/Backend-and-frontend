   M S B A M L   `   `   `  ����I  EEmberek_kutyak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Emberek_kutyakEmberek_kutyak  5   	       Emberek_kutyak.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Emberek_kutyak     5   	     � Title$  Emberek és kutyák��5   	   $	��525��6#   $	��800��60   $��18(�6<   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� .+�5      �� $��	Emberek: ��6   $
��Bold"�6(   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��Név: ��6   $��5q�6(   �� 5      -   5         ��Name$ tbox_nev��5   8   $	��150��6   $��30,5,5,5q�6&   68   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��
Életkor: ��6   $��5q�6,   �� 5      -   5        $ tbox_eletkor��5   1   $	��150��6   $��5q�6&   61   5      �� 5      -   5         ��Name$ btn_mentesEmber��5      $��Mentés��6j   $��5q�6{   {�6.   ��  �� ElementName$ tbox_nev�� �� Path$ Text.Length�6�   �� 5      -   5         ��Name$ 
lbox_ember��5      $��5q�6*   $	��150��65   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6Z   ��6B   �� ��5      �� 5      .R�5      �� .��5      �� .+�5   "   �� ��6,   �� *nev+	 �� Mode$	 TwoWay=��� 5   "   ��6,   �� *	eletkor+$	 TwoWay=�5       5!      5"      5&      �� 5(      $ 
Horizontal=�6   .+�5)      �� $��Név: ��6   $��5q�6(   �� 5*      $��80,5,5,5q�61   ��6   �� *nev+61   5+      �� 5,      $ 
Horizontal=�6   .+�5-      �� $��
Életkor: ��6   $��5q�6,   �� 5.      $��55,5,5,5q�64   ��6   �� *	eletkor+64   5/      �� 50      $ 
Horizontal=�6   .+�51      �� $��Kutyák száma: ��6   $��5q�61   �� 52      ��6   �� *kutyakszama+53      �� 54      $��
Nagyfülü��6   
 d� 	IsChecked
 6*   �� *
nagyfulu+56      �� 58   
   $��1��6   .+�59      �� $��Kutyak: ��6   $
��Bold"�6'   �� 5:      -   5         ��Name$ sp_kutya��5:      .+�5;      �� $ 
Horizontal=�6   .+�5<      �� $��Kutyanév: ��6   $��5q�61   �� 5=      -   5        $ tbox_kutyanev��5=   U   $	��150��6   $��5,5,5,5q�6D   ��6*   �� *
kutyaNev+6U   5>      �� 5?      $ 
Horizontal=�6   .+�5@      �� $��Fajta: ��6   $��5q�6.   �� 5A      -   5        $ 
tbox_fajta��5A   S   $	��150��6   $��40,5,5,5q�6*   ��6<   �� *fajta+6S   5B      5C      �� 5E      -   5        $ btn_mentesKutya��5E      $��Mentés��6.   $��5q�6?   ��5F      �� 5G       �� 
TargetType" ��6   .�5H      ��  �� Property � {� �� Value$
 True��66    �� Triggers 5I      ^� 5J       ^� 
Conditions 5K   "   �� 5L   &    �� Binding 60   �� $ tbox_kutyanev��$
 Text� �� Value  6i   �� 5N   &    60   �� $ 
tbox_fajta��$
 Text�  6f   .0�5P   "   ��  � {�$ False��6>   5Q      5S      5W      �� 5X      -	   5        $ 
lbox_kutya��5X      $��5q�6*   $	��150��65   $
 TrueY�6a   ��6B   �� *kutyak+��5Y      �� 5Z      .R�5[      �� .��5\      �� .+�5]   "   �� ��6,   �� *
kutyaNev+�� 5^   "   ��6,   �� *fajta+5_      5`      5a      5e      �� 5g      $��	Hűséges��6   
 6)   �� $ kutyak/huseges�5i      5j      5k      