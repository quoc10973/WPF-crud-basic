   M S B A M L   `   `   `  ���� S  OEnglishPremierLeague2024, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:EnglishPremierLeague2024EnglishPremierLeague2024  +    %EnglishPremierLeague2024.PlayerWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8local&clr-namespace:EnglishPremierLeague2024       � Title$  PlayerWindow��$	��480��$	��801�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� -   ���	#FFCBCACA.+�&   System.Windows.Controls.DataGrid  -     Name$ dgvFootballPlayer��   selectedTrigger   RowStyle# [  $��Center=�$	��181��$��0,36,0,0q�$	��Top=�$	��712��   AutoGenerateColumns$ False��   CanUserAddRows$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 	Player ID��	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 60 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *FootballPlayerId+  $ 	Full Name��$		 110 
 �� *
FullName+  $ Achivements��$		 130 
 �� *Achievements+  $ Birthday��$	 90 
 �� *
Birthday+  $ Experiences��$		 130 
 �� *PlayerExperiences+  $ 
Nomination��$		 200 
 �� *
Nomination+�� -    ��Name$ lblFootballPLayer��$��Football Player��$
��Left=�$��	44,10,0,0q�$	��Top=�$��31��$	��155��$��Arial Black)�$��Center=�$��16(����	#FF6A1111���	#00000000$
��Bold"��� -   $ lblId��$��ID��$
��Left=�$��
54,251,0,0q�$	��Top=� J� RenderTransformOrigin$ 
0.87,0.549&��� -    ��Name$ txtId��$
��Left=�$��138,254,0,0q� �� TextWrapping$ NoWrap=�$	��Top=�$��70���� -   $ lblFullName��$��Fullname��$
��Left=�$��
51,281,0,0q�$	��Top=�$ 
0.87,0.549&��� -   $ txtFullName��$
��Left=�$��138,285,0,0q�$ NoWrap=�$	��Top=�$	��114���� -   $ lblAchievements��$��Achievements��$
��Left=�$��
51,312,0,0q�$	��Top=�$ 
0.87,0.549&��� -	   $ txtAchievements��$
��Left=�$��137,316,0,0q�$ NoWrap=�$	��Top=�$	��263��$ 
0.525,1.35&��� -
   $ lblBirthday��$��Birthday��$
��Left=�$��434,252,0,0q�$	��Top=�$ 0.5,0.5&��� -   $ lblExperiences��$��Experiences��$
��Left=�$��434,283,0,0q�$	��Top=�$ 0.5,0.5&��� -   $ txtExperiences��$
��Left=�$��511,288,0,0q�$ NoWrap=�$	��Top=�$	��234���� -   $ lblNomination��$��
Nomination��$
��Left=�$��434,313,0,0q�$	��Top=�$ 0.5,0.5&��� -   $ txtNomination��$
��Left=�$��511,317,0,0q�$ NoWrap=�$	��Top=�$	��234��(  "System.Windows.Controls.DatePicker  -     Name$ dpkBirthday��$
��Left=�$��24��$��511,255,0,0q�$	��Top=�$	��234���� -   $ lblClubName��$��	Club Name��$
��Left=�$��269,264,0,0q�$	��Top=�$ 
0.87,0.549&��� -    ��Name$ cboClubName��$
��Left=�$��19��$��268,286,0,0q�$	��Top=�$	��132���� -    ��Name$ 	btnInsert��$��3��$��Insert��$
��Left=�$��302,392,0,0q�$	��Top=�$��88��$��21��
�������$	��0.4q����	#FF56048F$ 0.517,0.088&��� -   $ 	btnUpdate��$��3��$��Update��$
��Left=�$��417,392,0,0q�$	��Top=�$��88��$��21��
�������$	��0.4q����	#FF56048F$ 0.517,0.088&� � Cursor$
 Hand���� -   $ 	btnDelete��$��3��$��Delete��$
��Left=�$��539,392,0,0q�$	��Top=�$��88��$��21��
�������$	��0.4q����	#FF56048F$ 0.517,0.088&�$
 Hand���� -   $ btnClear��$��3��$��Reset��$
��Left=�$��658,392,0,0q�$	��Top=�$��88��$��21��
�������$	��0.4q����	#FF56048F$ 0.517,0.088&�$
 Hand���� -    ��Name$ 	grbDetail��$��Center=�$	��122��$�� Detail ��$	��Top=�$	��724��$��Italic$�$��Bahnschrift)�$��	0,235,0,0q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black��� $ 	#FFCE4DBD�� � Offset$ 1Q��� 
���   �$��1q�$
��Left=�$��41��$��294,382,0,0q�$	��Top=�$	��462���� -   $ 	lblOption��$��Option:��$
��Left=�$��321,363,0,0q�$	��Top=�$ -0.898,1.219&�$
��Bold"�$��Bahnschrift)��� -   $ btnShutdown��$
��Left=�$��0q�
������ $��239,385,0,0q�$	��Top=�$��38��$��42��.���� -    ��Name$ imgShutdown��$,��&pack://application:,,,/icon/button.png��$��30��$��30��$
 Hand�� J� Opacity$
 0.99Q��� -   $ btnManageAccount��$��3��$��Manage Account��$
��Left=�$��131,397,0,0q�$	��Top=�$	��101��$��21��
�������$	��0.4q����	#FF56048F$ 0.517,0.088&��� 
���   �$��1q�$
��Left=�$��0��$��
56,423,0,0q�$	��Top=�$	��168���� -   $ btnManagePlayer��$��3��$��Manage Club��$
��Left=�$��
17,397,0,0q�$	��Top=�$	��101��$��21��
�������$	��0.4q����	#FF56048F$ 0.517,0.088&��� -   $ 
lblWelcome��$��Welcome Admin��$
��Left=�$��
44,364,0,0q�$	��Top=�$��31��$	��155��$��Bradley Hand ITC)�$��Center=�$��16(����	#FF6A1111���	#00000000$
��Bold"�$��Italic$�