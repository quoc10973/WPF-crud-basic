   M S B A M L   `   `   `  ���� S  OEnglishPremierLeague2024, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:EnglishPremierLeague2024EnglishPremierLeague2024  )    #EnglishPremierLeague2024.ViewWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8local&clr-namespace:EnglishPremierLeague2024       � Title$  
ViewWindow��$	��563��$	��757�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� -   ���	#FFCBCACA$��Center=�$	��757��$��0,0,0,-6q�.+�&   System.Windows.Controls.DataGrid  -     Name$ dgvFoolballClub��   selectedTrigger   RowStyle# [  $��Center=�$	��181��$	��Top=�$	��712��   AutoGenerateColumns$ False��   CanUserAddRows$ False��$��0,61,0,0q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Football Club Id��	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *FootballClubId+  $ ClubName��$	 80 
 �� *
ClubName+  $ Description��$		 160 
 �� *ClubShortDescription+  $ Soccer Practice Field��$		 170 
 �� *SoccerPracticeField+  $ Mascos��$		 200 
 �� *Mascos+�� -    ��Name$ lblFootballClub��$��Football Club��$
��Left=�$��	24,35,0,0q�$	��Top=�$��31��$	��155��$��Arial Black)�$��Center=�$��16(����	#FF6A1111���	#00000000$
��Bold"��� -   $ 
lblWelcome��$��Welcome USer��$
��Left=�$��
304,14,0,0q�$	��Top=�$��31��$	��154��$��Bradley Hand ITC)�$��Center=�$��16(����	#FF6A1111���	#00000000$
��Bold"�$��Italic$� J� RenderTransformOrigin$ 1.117,1.234&��� -    ��Name$ btnShutdown��$
��Left=�$��0q�
������ $��667,479,0,0q�$	��Top=�$��37��$��40��$ 2.202,-3.088&�.���� -    ��Name$ imgShutdown��$��/icon/button.png��$��30��$��30�� � Cursor$
 Hand�� J� Opacity$
 0.99Q�$ -1.04,-3.709&��� $�� ��$
��Left=�$��12��$��570,276,0,0q�$	��Top=�$��91���� -   $ lblExit��$
��Exit��$
��Left=�$��623,485,0,0q�$	��Top=�$��31��$��46��$��Arial)�$��Center=�$��18(����	#FF6A1111���	#00000000$
��Bold"�$��Italic$�$ 1.117,1.234&�  -   $ dgvFootballPlayer��# [  $��Center=�$	��181��$	��Top=�$	��712��$ False��$ False��$��	0,285,0,0q�   $ 	Player ID��$	 60 
 �� *FootballPlayerId+  $ 	Full Name��$		 110 
 �� *
FullName+  $ Achivements��$		 130 
 �� *Achievements+  $ Birthday��$	 90 
 �� *
Birthday+  $ Experiences��$		 130 
 �� *PlayerExperiences+  $ 
Nomination��$		 200 
 �� *
Nomination+�� -	   $ lblFootballPLayer��$��Football Player��$
��Left=�$��
37,258,0,0q�$	��Top=�$��31��$	��155��$��Arial Black)�$��Center=�$��16(����	#FF6A1111���	#00000000$
��Bold"�$ 0.474,1.201&�