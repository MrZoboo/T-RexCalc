   M S B A M L   `   `   `  ����E  AMenuDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MenuDesign.MVVM.ViewMenuDesign.MVVM.View  5      %    MenuDesign.MVVM.View.VideosView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MenuDesign.MVVM.View     5      
������ .��5      � $��10q�6     � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   r� -   5        $��Player��5   y    r� Source$F @/Users/joser/source/repos/MenuDesign/MenuDesign/Media/bunny2.mp4?�6    r� LoadedBehavior$ Manual=�6a   6y   �� 5   
   $��1��6   .+�5      �� ���	#FF3E3D40$��74��5      $��Center=�5       �� CornerRadius$ 20,20,20,20��5      ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��imageViewer��5      $��60��5      $��60��5      $��10q�5      ��5      Z� 5      �� 5      $��Center=�6!   $��	20 0 30 0q�6<   .+�5       �� -   5        $��
lblStatus1��5!      $��Aperte Play��5    !   
�������$��22(�5#   $   $
��Bold"�5$   $   �� 5%      -   5        $��
lblStatus2��5%       $�� ��63   ���#9ae5c3$��18(�5'   $   $
��Bold"�5(   $   5*      �� 5,      -   5        $��btnBack��5-      $
��Back��5,      $��50��5/      $��70,10,10,10q�50      
�������$��14(�52         FormButtonTheme#��[  53      ��54      �� *HomeViewCommand+�� 55      -   5        $��btnPlay��56      $
��Play��55      $��50��58      $��10q�59      
�������$��14(�5;      #��[  5<      ��5=      �� *HomeViewCommand+�� 5>      -   5        $��btnPause��5?      $��Pause��5>      $��50��5A      $��10q�5B      
�������$��14(�5D      #��[  5E      ��5F      �� *HomeViewCommand+�� 5G      -   5        $��btnNext��5H      $
��Next��5G      $��50��5J      $��10q�5K      
�������$��14(�5M      #��[  5N      ��5O      �� *HomeViewCommand+5R      5U      5V      5W      5X      