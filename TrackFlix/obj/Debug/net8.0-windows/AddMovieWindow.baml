   M S B A M L   `   `   `  ����D  @TrackFlix, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TrackFlix	TrackFlix  5   	       TrackFlix.AddMovieWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TrackFlix     5   	     � Title$  	Add Movie��5   	   $	��300��6   $	��420��6(   .��5	      � .+�5   
   �� $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $��Movie Name: ��6V   $	��Top=�6j   $	��190��6�   �� 5   
   -   5         ��Name$ txtMovieName��5      $
��Left=�5      $��
200,10,0,0q�6-    �� TextWrapping$
 Wrap=�6A   $	��Top=�5   !   $	��190��69   �� 5   
   $
��Left=�6   $��	10,50,0,0q�6/   $
��Wrap=�6B   $��
Director: ��6V   $	��Top=�6h   $	��190��6�   �� 5   
   -   5        $ txtDirector��5   U   $
��Left=�6   $��
200,50,0,0q�6-   $
 Wrap=�6A   $	��Top=�6j   $	��190��6�   �� 5   
   $
��Left=�6   $��	10,90,0,0q�6/   $
��Wrap=�6B   $��Year: ��6V   $	��Top=�6d   $	��190��6|   �� 5   
   -   5        $ txtYear��5   U   $
��Left=�6   $��
200,90,0,0q�6-   $
 Wrap=�6A   $	��Top=�6f   $	��190��6~   �� 5   
   $
��Left=�6   $��
10,130,0,0q�6/   $
��Wrap=�6C   $��Duration (Minutes): ��6W   $	��Top=�6s   $	��190��6�   �� 5   
   -   5        $ 	txtMinute��5   V   $
��Left=�6   $��200,130,0,0q�6-   $
 Wrap=�6B   $	��Top=�6i   $	��190��6�   �� 5   
   $
��Left=�6   $��
10,170,0,0q�6/   $
��Wrap=�6C   $��Watch Status: ��6W   $	��Top=�6m   $	��190��6�   �� 5   
   -   5         ��Name$
 Seen��5   �   $
��Seen��6   $
��Left=�6"   $��200,170,0,0q�6=   $	��Top=�6R   $��18��6j   $��86��6v   6�   �� 5!   
   -   5        $	��Add��5!      $
��Left=�6   $��200,210,0,0q�6:   $	��Top=�6O   $��25��6g   $��90��6s   5"   	   �� 5%   
   -   5        $��Cancel��5%      $
��Left=�6"   $��300,210,0,0q�6=   $	��Top=�6R   $��25��6j   $��90��6v   5&   	   5(      5)      