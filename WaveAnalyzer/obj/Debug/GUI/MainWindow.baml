   M S B A M L   `   `   `  ����  WaveAnalyzer    WaveAnalyzer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Y UDynamicDataDisplay, Version=0.4.0.0, Culture=neutral, PublicKeyToken=5b7d744a7263923f^ ZDynamicDataDisplay.Maps, Version=0.1.0.0, Culture=neutral, PublicKeyToken=5b7d744a7263923fa ]DynamicDataDisplay.Markers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=5b7d744a7263923fAd34http://research.microsoft.com/DynamicDataDisplay/1.0    5   	     � Title$  
MainWindow��5   	   $	��600��6   $
��1220��6)   .��5      � -   5         �Name$ mainGrid��5      $��0,0,0,0q�6   .+�5   
   �� -   5         ��Name$ openFileButton��5      $��	Open File��6)   $
��Left=�6=   $��	36,28,0,0q�6X   $	��Top=�6k   $��75��6�   6�   �� 5   
   -   5         ��Name$ fileNameBox��5      $
��Left=�6'   $��23��6B   $��
138,28,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��192��6�   �� 5	   
   -   5        $ 
playButton��5	      $
��Play��6%   $
��Left=�64   $��
689,28,0,0q�6O   $	��Top=�6c   $��60��6{   6�   �� 5
   
   -   5        $ 
stopButton��5
      $
��Stop��6%   $
��Left=�64   $��
772,29,0,0q�6O   $	��Top=�6c   $��60��6{   6�   �� 5   
   $
��Left=�6   $��21��6/   $��
860,31,0,0q�6;   $
��Wrap=�6O   $��Frames��6c   $	��Top=�6q   $��60��6�   �� 5   
   -   5        $ 	framesBox��5      $
��Left=�6%   $��21��6@   $��
920,28,0,0q�6L   $
 Wrap=�6`   $��0��6t   $	��Top=�6}   $	��112��6�   �� 5   
   $
��Left=�6   $��21��6/   $��
346,29,0,0q�6;   $
��Wrap=�6O   $��Bitrate��6c   $	��Top=�6r   $��42��6�   �� 5   
   -   5        $ 
bitrateBox��5      $
��Left=�6&   $��21��6A   $��
393,29,0,0q�6M   $
 Wrap=�6a   $
��8000��6u   $	��Top=�6�   $��76��6�   �� 5   
   $
��Left=�6   $��21��6/   $��
485,30,0,0q�6;   $
��Wrap=�6O   $��Channels��6c   $	��Top=�6s   $��55��6�   �� 5   
   -   5        $ channelsBox��5      $
��Left=�6'   $��21��6B   $��
545,30,0,0q�6N   $
 Wrap=�6b   $��2��6v   $	��Top=�6   $��34��6�   �� 5   
   -	   5        $ 
readButton��5      $
��Read��6%   $
��Left=�64   $��
601,28,0,0q�6O   $	��Top=�6c   $��75��6{   6�   �� 5   
   -
   5        $��Find tonation!��5      $
��Left=�6*   $��1062,28,0,0q�6E   $	��Top=�6Z   $	��118��6r   $��79��6~   $��16(�6�   $
��Bold"�6�   6�   �� 5   
   -   5         ��Name$ pitchListBox��5      $
��Left=�6(   $	��379��6C   $��
36,155,0,0q�6P   $	��Top=�6d   $	��106��6|   6�   8  2Microsoft.Research.DynamicDataDisplay.ChartPlotter  5   
   -   5          Name$ pitchPlotter��5      
�������$��210,155,32,36q�6C      MainHorizontalAxis 5      M  GMicrosoft.Research.DynamicDataDisplay.Charts.Axes.HorizontalIntegerAxis  5      -   5          Name$ timeAxis��5   +   3  -Microsoft.Research.DynamicDataDisplay.Plotter	   Children.	 5      2  ,Microsoft.Research.DynamicDataDisplay.Header  ��6   �� *
PlotHeader+=  7Microsoft.Research.DynamicDataDisplay.VerticalAxisTitle  5      $��Frequency [Hz]��6#   ?  9Microsoft.Research.DynamicDataDisplay.HorizontalAxisTitle  5      $��	time [ms]��6%   5      �� 5   
   $
��Left=�6   $��223,109,0,0q�6/   $
��Wrap=�6D   $��Pitch��6X   $	��Top=�6e   $��20��6}   $��39��6�   �� 5   
   -   5        $ pitchBox��5      $
��Left=�6$   $��29��6?   $��297,105,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��106��6�   �� 5   
   $
��Left=�6   $��441,109,0,0q�6/   $
��Wrap=�6D   $��Frequency[Hz]��6X   $	��Top=�6m   $��20��6�   $	��112��6�   �� 5   
   -   5        $ 
pitchHzBox��5      $
��Left=�6&   $��29��6A   $��582,105,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��105��6�   �� 5    
   $
��Left=�6   $��	37,86,0,0q�6/   $
��Wrap=�6B   $!��Pitch changes at time: [ms]��6V   $	��Top=�6y   $��71��6�   �� 5!   
   -   5        $ notesFinderButton��5!      $��Find notes!��6,   $
��Left=�6B   $��
920,91,0,0q�6]   $	��Top=�6q   $	��112��6�   $��52��6�   $
��Bold"�6�   6�   5"      5#      