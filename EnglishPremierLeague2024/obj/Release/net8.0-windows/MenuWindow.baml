   M S B A M L   `   `   `  ���� S  OEnglishPremierLeague2024, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:EnglishPremierLeague2024EnglishPremierLeague2024  )    #EnglishPremierLeague2024.MenuWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8local&clr-namespace:EnglishPremierLeague2024       � Title$  
MenuWindow��$	��480��$	��801�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� -   ���	#FFCBCACA.+�&   System.Windows.Controls.DataGrid  -     Name$ dgvFoolballClub��   selectedTrigger   RowStyle# [  $��Center=�$	��181��$��0,36,0,0q�$	��Top=�$	��712��   AutoGenerateColumns$ False��   CanUserAddRows$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Football Club Id��	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *FootballClubId+  $ ClubName��$	 80 
 �� *
ClubName+  $ Description��$		 160 
 �� *ClubShortDescription+  $ Soccer Practice Field��$		 170 
 �� *SoccerPracticeField+  $ Mascos��$		 200 
 �� *Mascos+�� -    ��Name$ lblFootballClub��$��Football Club��$
��Left=�$��	44,10,0,0q�$	��Top=�$��31��$	��155��$��Arial Black)�$��Center=�$��16(����	#FF6A1111���	#00000000$
��Bold"��� -   $ lblId��$��ID��$
��Left=�$��
51,251,0,0q�$	��Top=� J� RenderTransformOrigin$ 
0.87,0.549&��� -    ��Name$ txtId��$
��Left=�$��122,254,0,0q� �� TextWrapping$ NoWrap=�$	��Top=�$	��121���� -   $ lblClubName��$��	Club name��$
��Left=�$��
51,281,0,0q�$	��Top=�$ 
0.87,0.549&��� -   $ txtClubName��$
��Left=�$��122,285,0,0q�$ NoWrap=�$	��Top=�$	��162���� -   $ lblDescription��$��Description
��$
��Left=�$��
51,312,0,0q�$	��Top=�$ 
0.87,0.549&��� -	   $ txtDescription��$
��Left=�$��123,315,0,0q�$ NoWrap=�$	��Top=�$	��288��$ 
0.525,1.35&��� -
   $ lblPracticeField��$��Practice Field��$
��Left=�$��426,276,0,0q�$	��Top=�$ 0.5,0.5&��� -   $ txtField��$
��Left=�$��511,281,0,0q�$ NoWrap=�$	��Top=�$	��234���� -   $ 	lblMascos��$��Mascos��$
��Left=�$��454,312,0,0q�$	��Top=�$ 0.5,0.5&��� -   $ 	txtMascos��$
��Left=�$��511,315,0,0q�$
 Wrap=�$	��Top=�$	��234���� -    ��Name$ 	btnInsert��$��3��$��Insert��$
��Left=�$��302,392,0,0q�$	��Top=�$��88��$��21��
�������$	��0.4q����	#FF56048F$ 0.517,0.088&��� -   $ 	btnUpdate��$��3��$��Update��$
��Left=�$��417,392,0,0q�$	��Top=�$��88��$��21��
�������$	��0.4q����	#FF56048F$ 0.517,0.088&� � Cursor$
 Hand���� -   $ 	btnDelete��$��3��$��Delete��$
��Left=�$��539,392,0,0q�$	��Top=�$��88��$��21��
�������$	��0.4q����	#FF56048F$ 0.517,0.088&�$
 Hand���� -   $ btnClear��$��3��$��Reset��$
��Left=�$��658,392,0,0q�$	��Top=�$��88��$��21��
�������$	��0.4q����	#FF56048F$ 0.517,0.088&�$
 Hand���� 
���   �$��1q�$
��Left=�$��41��$��294,382,0,0q�$	��Top=�$	��462���� -   $ 	lblOption��$��Option:��$
��Left=�$��321,363,0,0q�$	��Top=�$ -0.898,1.219&�$
��Bold"�$��Bahnschrift)��� -    ��Name$ 	grbDetail��$��Center=�$	��122��$�� Detail ��$	��Top=�$	��724��$��Italic$�$��Bahnschrift)�$��	0,235,0,0q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black��� $ 	#FFCE4DBD�� � Offset$ 1Q��� -   $ 
lblWelcome��$��Welcome Admin��$
��Left=�$��
43,364,0,0q�$	��Top=�$��31��$	��155��$��Bradley Hand ITC)�$��Center=�$��16(����	#FF6A1111���	#00000000$
��Bold"�$��Italic$��� -   $ btnShutdown��$
��Left=�$��0q�
������ $��237,385,0,0q�$	��Top=�$��38��$��42��.���� -    ��Name$ imgShutdown��$,��&pack://application:,,,/icon/button.png��$��30��$��30��$
 Hand�� J� Opacity$
 0.99Q��� -   $ btnManageAccount��$��3��$��Manage Account��$
��Left=�$��127,397,0,0q�$	��Top=�$	��101��$��21��
�������$	��0.4q����	#FF56048F$ 0.517,0.088&��� 
���   �$��1q�$
��Left=�$��0��$��
56,423,0,0q�$	��Top=�$	��168���� -   $ btnManagePlayer��$��3��$��Manage Player��$
��Left=�$��
17,397,0,0q�$	��Top=�$	��101��$��21��
�������$	��0.4q����	#FF56048F$ 0.517,0.088&�