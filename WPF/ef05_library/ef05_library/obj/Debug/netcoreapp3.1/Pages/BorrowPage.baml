   M S B A M L   `   `   `  ����G  Cef05_library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ef05_library.Pagesef05_library.Pages  5      #    ef05_library.Pages.BorrowPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:ef05_library.Pages     5        N� FontSize$  16(�5   0    N� Title$ 
BorrowPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��300 �6   �� 5      $��* �6   .+�5   
   �� .+�5      �� $��	Tanulók:��6   $
��Bold"�6'   $��5q�69   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��	Osztály:��6   $��5q�6+   �� 5      -   5         ��Name$ CBO_osztaly��5      $��5q�60   $��80��6;   5      5      �� 5      -   5         ��Name$ 
LB_tanulok��5      $��5q�6*   $	��300��65    �� DisplayMemberPath$ Fullname��5      5      �� 5      $��	Keresés:��6   $��5,5,5,0q�6'   �� 5      -   5         ��Name$ 
TB_kereses��5      $��5,0,5,5q�6*   5       5!      �� 5$   
   $��1��6   .+�5%      �� $��Kölcsönzött könyvek:��6   $
��Bold"�63   $��5q�6E   �� 5&      -   5        $ LB_kolcsonzottKonyvek��5&      $	��300��65   $��5q�6B   ��5'      �� 5(      .R�5)      �� 
��� � �$��1q�5*   !    �� CornerRadius$ 5��5+   !   	 �� Padding$	 5q�5,   !   $	��270��5-   !   ._�5.      �� .+�5/   "   �� $ 
Horizontal=�6-   .+�50   &   �� $��Cím: ��60   $
��Bold"�6=   �� 51   &   ��60   �� *Name+52   #   �� 53   "   $ 
Horizontal=�6-   .+�54   &   �� $��	Szerző: ��60   $
��Bold"�6@   �� 55   &   ��60   �� *
FullName+56   #   �� 57   "   $ 
Horizontal=�6-   .+�58   &   �� $��Kölcs.idő: ��60   $
��Bold"�6C   �� 59   &   ��60   �� *datum+5:   #   5;      5<      5=      5?      �� 5@      -   5        
 ��Name$
 
BTN_torles��5@      $��Törlés��6)   $��5q�6:   $��5q�6E   5A      5B      �� 5F   
   -   5         ��Name$ SP_kolcsonzes��5F   %   $��2��6   .+�5G      �� $��Kölcsönzés:��6   $
��Bold"�6*   $��5q�6<   �� 5H      $ 
Horizontal=�6   .+�5I      �� $��Szerző:��6   $��5q�6*   �� 5J      -   5        $ CBO_szerzok��5J      $��5q�60   $	��200��6;   $ FullName��5K      5L      5M      �� 5N      $��	Könyvek:��6   $��5q�6'   �� 5O      -   5        $ 
LB_konyvek��5O      $��5q�6*   $	��200��65   $
 Name��5P      �� 5Q      $ 
Horizontal=�6   .+�5R      �� $��Kiadva:��6   $��5q�6*   (  "System.Windows.Controls.DatePicker  5S      -	   5          Name$ 	DP_kiadva��5S      �� 5T      $	��-ig��6   $��5q�6&   5U      �� 5V      -
   5        $
 BTN_kolcsonoz��5V      $��Kölcsönöz��6,   $��5q�6@   $��5q�6K   5W      5X      5Y      5Z      