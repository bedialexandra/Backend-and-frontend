   M S B A M L   `   `   `  ����M  Iwpf17_papirgyujtes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:wpf17_papirgyujtes.Pageswpf17_papirgyujtes.Pages  5      .    (wpf17_papirgyujtes.Pages.StatisztikaPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:wpf17_papirgyujtes.Pages     5        N� Title$  StatisztikaPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� .+�5      �� $��STATISZTIKA��6   $��20(�6*   $
��Bold"�68   $��Center=�5      5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��220 �6#   �� 5      $	��200 �6#   �� 5      $��* �6#    5      �� 5      $
��auto �6    �� 5      $��* �6    .+�5"      �� $��2��6   .+�5#      �� $��Tanulónként��6   $
��Bold"�6.   $��16(�6@   $��Center=�5$      �� 5%       �� Orientation$ 
Horizontal=�6   .+�5&      �� $��	Osztály:��6   $��5q�6/   �� 5'      -   5         ��Name$ CBO_osztaly��5'      $��5q�64   $	��100��6?   5(      5)      5*      �� 5,      $��1��6   .+�5-      �� $��Névsor:��6   $��5q�6*   $
��Bold"�65   &   System.Windows.Controls.DataGrid  5.      -   5          Name$ DG_osszesites��5.         
IsReadOnly$
 True��62   $��5q�5/      $	��260��6&      AutoGenerateColumns$ False��50         Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Név��6-   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *nev+6R     53      $	 	Összesen��6-   $
 80 54   b    6-   �� *
osszesen+ �� StringFormat$ {0} dkg.��6b   56      57      �� 5:      $��1��6   $��1��6&   .+�5;      �� $%��Legtöbbet gyűjtött tanulók:��6   $��5q�6>   $
��Bold"�6I     5<      -   5        $ 
DG_legtobb��5<      $
 True��6/   $	��100��6A   $ False��5=       5>        5?      $
	 Név��6-   $
 * 6R    6:   �� *nev+6R     5@      $	 	Összesen��6-   $
 80 5A   b    6-   �� *
osszesen+$ {0} dkg.��6b   5C      �� 5E      $(��"Legkevesebbet gyűjtött tanulók:��6   $��5,15,5,5q�6B   $
��Bold"�6T     5F      -   5        $ DG_legkevesebb��5F      $
 True��63   $	��100��6E   $ False��5G       5H        5I      $
	 Név��6-   $
 * 6R    6:   �� *nev+6R     5J      $	 	Összesen��6-   $
 80 5K   b    6-   �� *
osszesen+$ {0} dkg.��6b   5M      5N      �� 5Q      $��0��6   $��2��6&   .+�5R      �� $��Osztályonként��6   $
��Bold"�60   $��5q�6B   $��Center=�5S      $��16(�65   5T      �� 5V      $��1��6   $��2��6&   .+�5W      �� $��Osztályok:��6   $��5q�6-   $
��Bold"�68     5X      -   5        $ DG_osztalyok��5X      $
 True��61   $��5q�5Y      $	��260��6&   $ False��5Z         AlternatingRowBackground
 �����   CanUserSortColumns$ False��5\         CanUserReorderColumns$ False��5]         CanUserResizeColumns$ False��5^         ColumnHeaderStyle 5`      �� 5a       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .�5b      ��  �� Property � �� �� Value$
 Bold"�6;   �� 5c       � ��
 ����6;   �� 5d       � ��$ 5q�68   �� 5e       � ��$ 0,0,1,0q�6@   �� 5f       � ��
 �����6<   �� 5g       �@ SeparatorVisibility$ Visible=�6D   �� 5h       �@ SeparatorBrush
 �����6?   5i       5l        5m      $	 Osztály��6-   $
 * 6Z    6>   �� *	osztaly+6Z     5n      $	 	Összesen��6-   $
 78 6u    6?   �� *
osszesen+$ {0} dkg.��6u     5o      $	 	Legkisebb��6-   $
 78 6w    6@   �� *	legkisebb+$ {0} dkg.��6w     5p      $	 
Legnagyobb��6-   $
 78 6y    6A   �� *
legnagyobb+$ {0} dkg.��6y     5q      $	 Darab��6-   $
 78 6n    6<   �� *darab+$ {0} db.��6n   5s      5t      5u      5w      5x      