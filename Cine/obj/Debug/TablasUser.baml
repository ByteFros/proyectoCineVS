   M S B A M L   `   `   `  ����?  ;Cine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CineCine  5   	       Cine.TablasUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Cine     5   	     � Title$
  MENU��5   	   $	��450��6   $	��800��6#   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $	��49* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ MoviesDataGrid��5         AutoGenerateColumns .  $��2��6i   $��0,92,0,0q�6}      CanUserAddRows .     
IsReadOnly . ��6+   �� *	Peliculas+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Título��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6P   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� *Titulo+6P     5      $ Idioma��6%   $
 Auto 6P   	 65   �� *Idioma+6P     5      $ 	Duración��6%   $
 Auto 6T   	 67   �� *
Duracion+6T     5      $
 Sala��6%   $
 Auto 6L   	 63   �� *Sala+6L     5      $ Fecha Inicio��6%   $
 Auto 6[   	 6;   �� *FechaInicio+6[     5      $ 	Fecha Fin��6%   $
 Auto 6U   	 68   �� *
FechaFin+6U     5      $ Genero��6%   $
 Auto 6S   	 65   �� *	showGenre+6S   5      �� 5   
   $��1��6   $
��Left=�6$   $��	10,22,0,0q�6?   $
��Wrap=�6R   $	��Top=�6f   $��25��6~   $	��210��6�   
 � Cursor$

 Help��6�   $��22(�6�   �� 5       � Language$ es-mx�6   $�Peliculas Disponibles��6#   5      �� 5"   
   -   5         ��Name$ 	AddMovies��5"      $��1��6$   $��Añadir Pelicula��64   $
��Left=�6N   $��
650,22,0,0q�6i   $	��Top=�6}   $��38��6�   $��88��6�   6�   �� 5%   
   -   5        $��1��5%      $��Cerrar Sesion��6!   $
��Left=�69   $��
554,22,0,0q�6T   $	��Top=�6h   $��38��6�   $��91��6�   6�   5&      5'      