   M S B A M L   `   `   `  ����G  Cef05_library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ef05_library.Pagesef05_library.Pages  5      !    ef05_library.Pages.PageBook   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:ef05_library.Pages     5        N� Title$  PageBook��5	       N� FontSize$ 16(�6   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   �� .+�5      �� $��	Szerzők:��6   $��5q�6'   $
��Bold"�62   �� 5      -   5         ��Name$ CBO_szerzok��5      $��5q�6,    �� DisplayMemberPath$ FullName��5      5      �� 5      -   5         ��Name$ 
LB_konyvek��5      $	��300��6*   $��5q�67   $
 Name��5      5      �� 5      -   5         ��Name$ BTN_uj��5      $��
Új könyv��6%   $��5q�68   $��5q�6C   5      �� 5      -   5        $ BTN_modosit��5      $��Módosítás��6*   $��5q�6>   $��5q�6I   5      �� 5      -   5        $ 	BTN_torol��5      $��Törlés��6(   $��5q�69   $��5q�6D   5       5!      �� 5$   
   -   5         ��Name$ SP_konyv��5$   %   $��1��6   .+�5%      �� $��Könyv adatok:��6   $��5q�6,   $
��Bold"�67   �� 5&       �� Orientation$ 
Horizontal=�6   $��5q�62   .+�5'      �� $��Könyv címe:��6   $	��100��6.   �� 5(      $	��200��6   ��6&   �� *Name+5)      �� 5*      $ 
Horizontal=�6   $��5q�62   .+�5+      �� $��Oldalszám:��6   $	��100��6-   �� 5,      $��50��6   ��6%   �� *	Pagecount+5-      �� 5.      $ 
Horizontal=�6   $��5q�62   .+�5/      �� $��
Pontszám:��6   $	��100��6,   �� 50      $��50��6   ��6%   �� *Point+51      �� 52      $ 
Horizontal=�6   $��5q�62   .+�53      �� $��Szerző:��6   $	��100��6*   �� 54      -   5        $ CBO_szerzok2��54      $	��200��61   $ FullName��55      	 �� SelectedValuePath$	 AuthorId��56      
 �� SelectedValue
 57      �� *
AuthorId+58      �� 59      $ 
Horizontal=�6   $��5q�62   .+�5:      �� $��Típus:��6   $	��100��6)   �� 5;      -   5        $ 	CBO_tipus��5;      $	��200��6.   $
 Name��5<      $	 TypeId��5=      
 5>      �� *TypeId+5?      �� 5@      $ 
Horizontal=�6   $��0,20,0,0q�62   .+�5A      �� -	   5        $ 
BTN_mentes��5A      $��Mentés��6-   $��5q�6>   $��5q�6I   5B      �� 5C      -
   5        $ 	BTN_megse��5C      $��Mégse��6,   $��	170,5,5,5q�6<   $��5q�6O   5D      5E      5F      5G      5H      