   M S B A M L   `   `   `  ����  Assignment 5 lvl2*    $Assignment_5_lvl2.ControlTowerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  ControlTowerWindow1��5   	    � Title$ Control Tower��5   	   $	��465��6   $	��525��6,    � WindowStartupLocation$ CenterScreen=�68   .��5      � -   5         �Name$ gridMain��5       � RowDefinitions 5   
   �� 5      $	��25* �6   �� 5      .+�5
   
   ]� -   5         ]�Name$ dockpanMain��5
      ��.  $��	0,0,0,386q�6?   .+�5      o� -   5         o�Name$ menuMain��5      $��31��6%   $	��Top=�61   $	��Top=�6I   .@�5      m� -   5         m�Name$ menuFile��5      $
��File��6-   .@�5      �� -   5         ��Name$ menuSeparator��5       69   m� 5      -   5        $ menuExit��5      $
��Exit��61   6?   5      5      5      �� 5   
   -   5        	 ��Name$	 	lstStatus��5      $	��286��6&   $��
32,36,32,0q�63   $	��Top=�6G   ���	#FFEEEEEE5      �� 5   
   -	   5        
 ��Name$
 tbFlightCode��5      $
��Left=�6(   $��23��6C   $��105,365,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -
   5         ��Name$ lblNextFlight��5      $��Flightcode:��6'   $
��Left=�6=   $��
32,362,0,0q�6X   $	��Top=�6l   �� 5   
   -   5         ��Name$ btnSendPlaneToRunway��5      $��Send next plane to Runway��6/   $
��Left=�6S   $��298,356,0,0q�6n   $	��Top=�6�   $	��187��6�   $��38��6�   6�   5      5      