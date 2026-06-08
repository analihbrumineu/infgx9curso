using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using com.genexus;
using com.genexus.ui;
using com.genexus.uifactory;
using GeneXus.Windows;
using GeneXus.Data;
using com.genexus.distributed;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class bmenuprincipal : GXWinMenuBar
   {
      public bmenuprincipal( IGxContext context ,
                             GXWorkpanel wp ) : base(context, wp)
      {
      }

      public bmenuprincipal( IGxContext context ,
                             Object wp ) : base(context, wp)
      {
      }

      public override void initMenuBar( )
      {
         IMenu menu2 = UIFactory.getMenu( "Configuração" , "id_configuracao" , "", 0,  true );
         add( menu2 );
         addMenuItem( menu2 , "Movimentação" , "id_mov" , "" , 0 , false , true , false , 0 );
         addMenuItem( menu2 , "Preços" , "id_precos" , "" , 0 , false , true , false , 0 );
         IMenu menu5 = UIFactory.getMenu( "Cadastro" , "id_clientes" , "", 0,  true );
         add( menu5 );
         addMenuItem( menu5 , "Estados" , "id_estados" , "" , 0 , false , true , false , 0 );
         addMenuItem( menu5 , "Cidades" , "id_cidades" , "" , 0 , false , true , false , 0 );
         addMenuItem( menu5 , "Categorias" , "id_categorias" , "" , 0 , false , true , false , 0 );
         addMenuItem( menu5 , "Astros" , "id_astros" , "" , 0 , false , true , false , 0 );
         addMenuItem( menu5 , "Filmes" , "id_filmes" , "" , 0 , false , true , false , 0 );
         addMenuItem( menu5 , "Mídias" , "id_midias" , "" , 0 , false , true , false , 0 );
         addMenuItem( menu5 , "Clientes" , "id_clientes" , "" , 0 , false , true , false , 0 );
         addMenuItem( menu5 , "Funcionários" , "id_funcionarios" , "" , 0 , false , true , false , 0 );
         IMenu menu14 = UIFactory.getMenu( "Relatório" , "id_relatorio" , "", 0,  true );
         add( menu14 );
         addMenuItem( menu14 , "Total de filmes por categoria" , "id_fil_p_categoria" , "" , 0 , false , true , false , 0 );
         addMenuItem( menu14 , "Clientes com dependentes" , "id_cli_c_dependente" , "" , 0 , false , true , false , 0 );
         addMenuItem( menu14 , "Total de mídias por categoria" , "id_tot_mid_p_cat" , "" , 0 , false , true , false , 0 );
         addToolBarButton( "" , "h" , "" , false , false );
      }

      public override bool menuActionPerformed( String action )
      {
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_astros".TrimEnd(' ') ) == 0 ) )
         {
            E11011 ();
            return true;
         }
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_categorias".TrimEnd(' ') ) == 0 ) )
         {
            E12011 ();
            return true;
         }
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_cidades".TrimEnd(' ') ) == 0 ) )
         {
            E13011 ();
            return true;
         }
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_clientes".TrimEnd(' ') ) == 0 ) )
         {
            E14011 ();
            return true;
         }
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_estados".TrimEnd(' ') ) == 0 ) )
         {
            E15011 ();
            return true;
         }
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_filmes".TrimEnd(' ') ) == 0 ) )
         {
            E16011 ();
            return true;
         }
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_funcionarios".TrimEnd(' ') ) == 0 ) )
         {
            E17011 ();
            return true;
         }
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_mov".TrimEnd(' ') ) == 0 ) )
         {
            E18011 ();
            return true;
         }
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_midias".TrimEnd(' ') ) == 0 ) )
         {
            E19011 ();
            return true;
         }
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_fil_p_categoria".TrimEnd(' ') ) == 0 ) )
         {
            E20011 ();
            return true;
         }
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_cli_c_dependente".TrimEnd(' ') ) == 0 ) )
         {
            E21011 ();
            return true;
         }
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_tot_mid_p_cat".TrimEnd(' ') ) == 0 ) )
         {
            E22011 ();
            return true;
         }
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "id_precos".TrimEnd(' ') ) == 0 ) )
         {
            E23011 ();
            return true;
         }
         return false;
      }

      protected void E11011( )
      {
         /* Menubar_Id_astros Routine */
         new wpeastro(context, remoteHandle, jContext ).execute( ) ;
      }

      protected void E12011( )
      {
         /* Menubar_Id_categorias Routine */
         new wpecategoria(context, remoteHandle, jContext ).execute( ) ;
      }

      protected void E13011( )
      {
         /* Menubar_Id_cidades Routine */
         new wpecidade(context, remoteHandle, jContext ).execute( ) ;
      }

      protected void E14011( )
      {
         /* Menubar_Id_clientes Routine */
         new wpecliente(context, remoteHandle, jContext ).execute( ) ;
      }

      protected void E15011( )
      {
         /* Menubar_Id_estados Routine */
         new wpeestado(context, remoteHandle, jContext ).execute( ) ;
      }

      protected void E16011( )
      {
         /* Menubar_Id_filmes Routine */
         new pretfunlogdados(context, remoteHandle, jContext ).execute( out  AV1Funcion) ;
         if ( ( AV1Funcion.gxTpr_Pesfuncargo != 1 ) )
         {
            GXutil.msg( this, "Apenas gerentes podem acessar este menu!" );
         }
         else
         {
            new wpefilme(context, remoteHandle, jContext ).execute( ) ;
         }
      }

      protected void E17011( )
      {
         /* Menubar_Id_funcionarios Routine */
         new pretfunlogdados(context, remoteHandle, jContext ).execute( out  AV1Funcion) ;
         if ( ( AV1Funcion.gxTpr_Pesfuncargo != 1 ) )
         {
            GXutil.msg( this, "Apenas gerentes podem acessar este menu!" );
         }
         else
         {
            new wpefuncionario(context, remoteHandle, jContext ).execute( ) ;
         }
      }

      protected void E18011( )
      {
         /* Menubar_Id_mov Routine */
         new wpelocacao(context, remoteHandle, jContext ).execute( ) ;
      }

      protected void E19011( )
      {
         /* Menubar_Id_midias Routine */
         new pretfunlogdados(context, remoteHandle, jContext ).execute( out  AV1Funcion) ;
         if ( ( AV1Funcion.gxTpr_Pesfuncargo != 1 ) )
         {
            GXutil.msg( this, "Apenas gerentes podem acessar este menu!" );
         }
         else
         {
            new wpemidia(context, remoteHandle, jContext ).execute( ) ;
         }
      }

      protected void E20011( )
      {
         /* Menubar_Id_fil_p_categoria Routine */
         new wrelfilporcategoria(context, remoteHandle, jContext ).execute( ) ;
      }

      protected void E21011( )
      {
         /* Menubar_Id_cli_c_dependente Routine */
         new wrelclicomdependente(context, remoteHandle, jContext ).execute( ) ;
      }

      protected void E22011( )
      {
         /* Menubar_Id_tot_mid_p_cat Routine */
         new wrelmid(context, remoteHandle, jContext ).execute( ) ;
      }

      protected void E23011( )
      {
         /* Menubar_Id_precos Routine */
         new pretfunlogdados(context, remoteHandle, jContext ).execute( out  AV1Funcion) ;
         if ( ( AV1Funcion.gxTpr_Pesfuncargo != 1 ) )
         {
            GXutil.msg( this, "Apenas gerentes podem acessar este menu!" );
         }
         else
         {
            new wconftipmidia(context, remoteHandle, jContext ).execute( ) ;
         }
      }

      public override void initialize( )
      {
         AV1Funcion = new SdtSDTFuncionario(context);
      }

      protected SdtSDTFuncionario AV1Funcion ;
   }

}
