   M S B A M L   `   `   `  ����D  @TrackFlix, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TrackFlix	TrackFlix  5   	       TrackFlix.AddMovieWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TrackFlix     5   	     � Title$  	Add Movie��5   	   $	��300��6   $	��420��6(    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�6   .��5
      � 
���   �$��Verdana)�6   .+�5   
   �� $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $��Movie Name: ��6V   $	��Top=�5      $	��190��6,   
�������69   �� 5   
   -   5         ��Name$ txtMovieName��5      $
��Left=�5      $��
200,10,0,0q�6-    �� TextWrapping$
 Wrap=�6A   $	��Top=�5   !   $	��190��69   �� 5   
   $
��Left=�6   $��	10,50,0,0q�6/   $
��Wrap=�6B   $��
Director: ��6V   $	��Top=�5      $	��190��6,   
�������69   �� 5   
   -   5        $ txtDirector��5   U   $
��Left=�6   $��
200,50,0,0q�6-   $
 Wrap=�6A   $	��Top=�5      $	��190��6*   �� 5   
   $
��Left=�6   $��	10,90,0,0q�6/   $
��Wrap=�6B   $��Year: ��6V   $	��Top=�5      $	��190��6,   
�������69   �� 5   
   -   5        $ txtYear��5   U   $
��Left=�6   $��
200,90,0,0q�6-   $
 Wrap=�6A   $	��Top=�5      $	��190��6*   �� 5   
   $
��Left=�6   $��
10,130,0,0q�6/   $
��Wrap=�6C   $��Duration (Minutes): ��6W   $	��Top=�5      $	��190��6,   
�������69   �� 5    
   -   5        $ 	txtMinute��5    V   $
��Left=�6   $��200,130,0,0q�6-   $
 Wrap=�6B   $	��Top=�5!      $	��190��6*   �� 5$   
   $
��Left=�6   $��
10,170,0,0q�6/   $
��Wrap=�6C   $��Watch Status: ��6W   $	��Top=�5%      $	��190��6,   
�������69   �� 5'   
   -   5         ��Name$
 Seen��5(   B   $
��Seen��5'      $
��Left=�6"   $��200,170,0,0q�6=   $	��Top=�5(      $��18��6+   $��86��67   
�������6Q   �� 5+   
   -   5        $	��Add��5+      $
��Left=�6   $��200,210,0,0q�6:   $	��Top=�5,      $��25��6)   $��90��65   ���#ffffff
���  ��5.      �� 51   
   -   5        $��Cancel��51      $
��Left=�6"   $��300,210,0,0q�6=   $	��Top=�52      $��25��6)   $��90��65   ���#ffffff
���  ��54      56      57      