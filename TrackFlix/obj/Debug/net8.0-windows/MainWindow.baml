   M S B A M L   `   `   `  ����D  @TrackFlix, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TrackFlix1
TrackFlix1  5   	       TrackFlix1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TrackFlix1     5   	     � Title$3  -TrackFlix: Personal Movie Tracker Desktop App��5      $	��350��6>   $	��800��6K    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�6.   
���   �.��5
      � 
���   �$��Verdana)�6   .+�5   
   �� -   5        $	��Add��5      $
��Left=�5      $��	20,20,0,0q�5      $	��Top=�5      $	��150��5      ���#ffffff
���  ��5      �� 5   
   -   5        $
��Edit��5      $
��Left=�5      $��	20,46,0,0q�5      $	��Top=�5      $	��150��6)   ���#ffffff
���  ��5      �� 5    
   -   5        $��Filter��5       $
��Left=�5!      $��	20,72,0,0q�5"      $	��Top=�5#      $	��150��6)   ���#ffffff
���  ��5&      �� 5)   
   -   5        $��Clear Filter��5)      $
��Left=�5*      $��	20,98,0,0q�5+      $	��Top=�5,      $	��150��6)   ���#ffffff
���  ��5/      �� 52   
   -   5        $��Delete��52      $
��Left=�53      $��
20,124,0,0q�54      $	��Top=�55      $	��150��6)   ���#ffffff
���  ��58      &   System.Windows.Controls.DataGrid  5;   
   -   5          Name$ DataGrid��5;         AutoGenerateColumns$ False��5=      $��190,10,10,60q�5>         SelectionMode$ Single=�5?      
���   �   
IsReadOnly$
 True��5A      ��5<      �� *Movies+   Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Movie Name��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 200 5G   %   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5F   %   �� *	MovieName+5G   %     5H      $ Director��6%   $		 150 5J   %   
 5I   %   �� *
Director+5J   %     5K      $
 Year��6%   $	 75 5M   %   
 5L   %   �� *Year+5M   %     5N      $ Duration��6%   $	 75 5P   %   
 5O   %   �� *
Duration+5P   %     5Q      $ Status��6%   $	 * 5S   %   
 5R   %   �� *Seen+5S   %   5U      � 5X   
   -   5         �Name$ ProgressBar��5X      $��Stretch=�5Y      $��Bottom=�5Z      $��20��5[      $��10,10,10,30q�5\       � Minimum$ 0Q�5]       � Maximum$	 100Q�5^       � Value$ 0Q�5_      
���  ��5`      �� 5c   
   -   5         ��Name$ WatchProgressLabel��5c      $��Center=�5d      $��Bottom=�5e      $��
10,0,10,10q�5f      
�������$��14(�5h      $��Watch Progress: 0 / 0��5i      5k      5l      