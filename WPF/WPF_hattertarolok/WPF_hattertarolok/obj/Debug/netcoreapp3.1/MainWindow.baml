   M S B A M L   `   `   `  ����L  HWPF_hattertarolok, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPF_hattertarolokWPF_hattertarolok  5   	   "    WPF_hattertarolok.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WPF_hattertarolok     5   	     � Title$  Háttértároló��5   	   $	��500��6   $	��800��6+   $��14(�67    � 	Resources 5	          BooleanToVisibilityConverter��%   &	        �� 5
   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��30 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� .+�5      �� $��Háttértároló��6   $��5q�6+   $
��Bold"�66   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��Méret: ��6   $��5q�6*   �� 5      -   5         ��Name$ tbox_ujHatterTaroloMeret��5      $��5q�6<   $��60��6G   �� 5      $��Kbyte��6   $��5q�6(   5      �� 5      -   5         ��Name$ btn_ujHatterTarolo��5   a   $	��Új��6}   $��5q�6�   $��5q�6�   {�6   ��  �� ElementName$ tbox_ujHatterTaroloMeret�� �� Path$ Text.Length�6�   �� 5       -   5        	 ��Name$	 lbox_hatterTarolo��5    ;   $
 �� IsSynchronizedWithCurrentItem$

 TrueY�6   $��5q�6V   $	��100��6a    �� DisplayMemberPath$ maxkapacitas��6�   ��6n   �� 6�   �� 5!      $
��Bold"�6   $��Adatok: ��6&   $��5,15,5,5q�69   �� 5"      $��5q�6\   ��6   �� *maxkapacitas+ �� StringFormat$ Maxkapacitás: {0} Kbyte��6\   �� 5#      $��5q�6f   ��6   �� *foglaltKapacitas+$$ Foglaltkapacitás: : {0} Kbyte��6f   �� 5$      $��5q�6d   ��6   �� *szabadKapacitas+$# Szabadkapacitás: : {0} Kbyte��6d   �� 5&      �� 5'      $��Írásvédett��6   $��5q�6,   $��Center=�5(      y�5)      �� $ lezarvaFloppyMutat� �� 	Converter# [   �� FallbackValue$ hidden�� d� 	IsChecked 5*      �� *
irasvedett+5+      �� 5-   
   $��1��6   .+�5.      �� -   5         ��Name$ gbox_ujfajl��5.   .   $��5q�6   $��5q�6"   ��5/      �� 50      $��Új fájl hozzáadása��6    $
��Bold"�6:   .��53      �� .+�54      �� $��Fájlnév: ��6   $��5q�60   �� 55      -   5        $ tbox_fajlnev��55      $��5,0,5,0q�64   ��6E   �� *	fajlnev+�� 57      $��Méret: ��6   $��5q�6.   �� 58      -   5        $ 
tbox_meret��58      $��5,0,5,0q�62   ��6C   �� *meret+�� 5:      $��Csak olvasható��6   $��5q�68    6C   �� *csakolvashato+�� 5;      $��Rendszer��6   $��5q�62    6=   �� *
rendszer+�� 5<      $��Rejtett��6   $��5q�61    6<   �� *	rejtett+�� 5>      -   5        $ 
btn_ujfajl��5>      $��	Új fájl��61   $��5,15,5,5q�6C   $��5q�6U   ��5?      �� 5@       �� 
TargetType" ��6$   .�5A   "   ��  �� Property � {� �� Value$
 True��6>    �� Triggers 5B   "   ^� 5C   &    ^� 
Conditions 5D   *   �� 5E   .    �� Binding 68   �� $ tbox_fajlnev��$ Text.Length� �� Value 06v   .0�5G   *   ��  � {�$ False��6F   5H   '   5K      5N      5O      5P      �� 5Q      $��5q�6   �� 5R      -   5        $ btn_ujfloppy��5R      $��
Új floppy��6+   $��5q�6?   $��5q�6J   6V   5S      �� 5T   
   $��2��6   .+�5U      �� $��Fájlok��6   $
��Bold"�6%   �� 5V      -	   5        $	 lbox_fajlok��5V   ;   $

 TrueY�6   $��5q�6P   $	��200��6[   $ fajlnev��6�   ��6h   �� *fajlok+6�   �� 5W      -
   5        $ 	BTN_torol��5W      $��Törlés��6(   $��5q�69   $��5q�6D   {�6h   �� $ lbox_fajlok��$ SelectedItems.Count��� 5X      -   5        $ btn_formazas��5X      $��
Formázás��6+   $��5q�6>   $��5q�6I   6U   5Y      �� 5Z   
   $��3��6   .+�5[      �� $��5q�6   $��5q�6"   ��5\      �� 5^      $��Fájl módosítás��6$   $
��Bold"�6<   .��5c      �� .+�5d      �� $��5q�6    ��5e      �� $ fajlok/fajlnev�$ Fájlnév: {0}���� 5f      $��5q�6    ��5g      �� $ fajlok/meret�$ Méret: {0} Kbyte���� 5h      $��Csak olvasható��6   $��Center=�6h   $��5q�6�    68   �� $ fajlok/csakolvashato�6�   �� 5i      $��Rendszer��6   $��Center=�6]   $��5q�6    62   �� $ fajlok/rendszer�6   �� 5j      $��Rejtett fájl��6   $��Center=�6d   $��5q�6�    66   �� $ fajlok/rejtettfajl�6�   5k      5m      �� 5n      .��5o      �� .+�5p      �� $��Fájlnév: ��6   $��5q�60   �� 5q      -   5        $ tbox_fajlnevKereses��5q      $��5,0,0,5q�6;   �� 5r      -   5        $ 	btn_keres��5r   d   $��Keresés��6w   $��5q�6�   $��5q�6�   {�6   �� $ tbox_fajlnevKereses��$ Text.Length�6�   �� 5s      -   5         ��Name$ tbl_fajlTalalat��5s       $��5,15,5,5q�69   5t      5u      5v      �� 5w   
   $��1��6   $��4��6!   
���  ��$��5q�6b   ��6F   �� *
hibauzenet+6b   5x      5y      