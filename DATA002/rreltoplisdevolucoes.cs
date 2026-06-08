/*
               File: RelTopLisDevolucoes
        Description: Relatório do total de devoluções.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/5/2026 9:0:14.10
       Program type: Callable routine
          Main DBMS: sqlserver
*/
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
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class rreltoplisdevolucoes_wrapper : GXJWin
   {
      public rreltoplisdevolucoes_wrapper( int hnd ,
                                           ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class rreltoplisdevolucoes : GXWinProcedure
   {
      public rreltoplisdevolucoes( int hnd ,
                                   ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
      }

      public rreltoplisdevolucoes( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public rreltoplisdevolucoes( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
      }

      public rreltoplisdevolucoes( IGxContext context ,
                                   int hnd ,
                                   ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         rreltoplisdevolucoes objrreltoplisdevolucoes;
         objrreltoplisdevolucoes = new rreltoplisdevolucoes();
         objrreltoplisdevolucoes.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrreltoplisdevolucoes.executePrivateCatch ));
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e  )
         {
            GXUtil.SaveToEventLog( "AgoraVaiCurso", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         this.cleanup();
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

   }

}
