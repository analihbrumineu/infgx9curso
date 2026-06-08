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
using GeneXus.Forms;
using System.Windows.Forms;
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
   public class GxDeveloperMenu : GxMenu
   {
      public override void LoadMenu( )
      {
         TreeNode nodeToAdd ;
         TreeNode childNode ;
         nodeToAdd = new TreeNode( GXResourceManager.GetMessage("devmenuscr")) ;
         this.Nodes.Add( nodeToAdd);
         childNode = new TreeNode( "Cadastro de Estados.") ;
         childNode.Tag = "WPeEstado" ;
         nodeToAdd.Nodes.Add( childNode);
         childNode = new TreeNode( "Cadastro de cidades") ;
         childNode.Tag = "WPeCidade" ;
         nodeToAdd.Nodes.Add( childNode);
         childNode = new TreeNode( "Cadastro de categorias.") ;
         childNode.Tag = "WPeCategoria" ;
         nodeToAdd.Nodes.Add( childNode);
         childNode = new TreeNode( "Cadastro de filmes.") ;
         childNode.Tag = "WPeFilme" ;
         nodeToAdd.Nodes.Add( childNode);
         childNode = new TreeNode( "Cadastro de mídias.") ;
         childNode.Tag = "WPeMidia" ;
         nodeToAdd.Nodes.Add( childNode);
         childNode = new TreeNode( "Cadastro de clientes.") ;
         childNode.Tag = "WPeCliente" ;
         nodeToAdd.Nodes.Add( childNode);
         childNode = new TreeNode( "Cadastro de funcionário.") ;
         childNode.Tag = "WPeFuncionario" ;
         nodeToAdd.Nodes.Add( childNode);
         childNode = new TreeNode( "Cadastro de astros.") ;
         childNode.Tag = "WPeAstro" ;
         nodeToAdd.Nodes.Add( childNode);
         childNode = new TreeNode( "Impressão de relatório de filmes por categoria.") ;
         childNode.Tag = "WRelFilPorCategoria" ;
         nodeToAdd.Nodes.Add( childNode);
         childNode = new TreeNode( "Impressão de relatório de clientes com dependentes.") ;
         childNode.Tag = "WRelCliComDependente" ;
         nodeToAdd.Nodes.Add( childNode);
         childNode = new TreeNode( "Impressão de relatórios de mídia.") ;
         childNode.Tag = "WRelMid" ;
         nodeToAdd.Nodes.Add( childNode);
         childNode = new TreeNode( "Configurações tipo de mídia.") ;
         childNode.Tag = "WConfTipMidia" ;
         nodeToAdd.Nodes.Add( childNode);
         childNode = new TreeNode( "Cadastro de locação") ;
         childNode.Tag = "WPeLocacao" ;
         nodeToAdd.Nodes.Add( childNode);
      }

      public override void ExecuteOption( string pgmName )
      {
         string[] args ;
         if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WPeEstado".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wpeestado"));
            com.genexus.Application.init(thisClass);
            wpeestado pgm = new wpeestado (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
         else if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WPeCidade".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wpecidade"));
            com.genexus.Application.init(thisClass);
            wpecidade pgm = new wpecidade (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
         else if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WPeCategoria".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wpecategoria"));
            com.genexus.Application.init(thisClass);
            wpecategoria pgm = new wpecategoria (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
         else if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WPeFilme".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wpefilme"));
            com.genexus.Application.init(thisClass);
            wpefilme pgm = new wpefilme (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
         else if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WPeMidia".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wpemidia"));
            com.genexus.Application.init(thisClass);
            wpemidia pgm = new wpemidia (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
         else if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WPeCliente".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wpecliente"));
            com.genexus.Application.init(thisClass);
            wpecliente pgm = new wpecliente (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
         else if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WPeFuncionario".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wpefuncionario"));
            com.genexus.Application.init(thisClass);
            wpefuncionario pgm = new wpefuncionario (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
         else if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WPeAstro".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wpeastro"));
            com.genexus.Application.init(thisClass);
            wpeastro pgm = new wpeastro (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
         else if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WRelFilPorCategoria".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wrelfilporcategoria"));
            com.genexus.Application.init(thisClass);
            wrelfilporcategoria pgm = new wrelfilporcategoria (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
         else if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WRelCliComDependente".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wrelclicomdependente"));
            com.genexus.Application.init(thisClass);
            wrelclicomdependente pgm = new wrelclicomdependente (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
         else if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WRelMid".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wrelmid"));
            com.genexus.Application.init(thisClass);
            wrelmid pgm = new wrelmid (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
         else if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WConfTipMidia".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wconftipmidia"));
            com.genexus.Application.init(thisClass);
            wconftipmidia pgm = new wconftipmidia (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
         else if ( ( String.CompareOrdinal(pgmName.TrimEnd(' '), "WPeLocacao".TrimEnd(' ') ) == 0 ) )
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.wpelocacao"));
            com.genexus.Application.init(thisClass);
            wpelocacao pgm = new wpelocacao (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = this ;
            pgm.execute();
         }
      }

      public static void Main( )
      {
         try
         {
            System.Windows.Forms.Application.Run( new GxDeveloperMenu());
         }
         catch ( Exception e  )
         {
            GXUtil.SaveToEventLog( "AgoraVaiCurso", e);
            throw e ;
         }
      }

   }

}
