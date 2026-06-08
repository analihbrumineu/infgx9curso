/*
               File: RelTopDeLisDevolucoes
        Description: Relatório do total de devoluções.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/5/2026 9:17:45.63
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
   public class rreltopdelisdevolucoes_wrapper : GXJWin
   {
      public rreltopdelisdevolucoes_wrapper( int hnd ,
                                             ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class rreltopdelisdevolucoes : GXWinProcedure
   {
      public rreltopdelisdevolucoes( int hnd ,
                                     ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
      }

      public rreltopdelisdevolucoes( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public rreltopdelisdevolucoes( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
      }

      public rreltopdelisdevolucoes( IGxContext context ,
                                     int hnd ,
                                     ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( DateTime aP0_DatInicial ,
                           DateTime aP1_DatFinal ,
                           long aP2_Selecao )
      {
         this.AV8DatInic = aP0_DatInicial;
         this.AV9DatFina = aP1_DatFinal;
         this.AV10Seleca = aP2_Selecao;
         initialize();
         executePrivate();
      }

      public void executeSubmit( DateTime aP0_DatInicial ,
                                 DateTime aP1_DatFinal ,
                                 long aP2_Selecao )
      {
         rreltopdelisdevolucoes objrreltopdelisdevolucoes;
         objrreltopdelisdevolucoes = new rreltopdelisdevolucoes();
         objrreltopdelisdevolucoes.AV8DatInic = aP0_DatInicial;
         objrreltopdelisdevolucoes.AV9DatFina = aP1_DatFinal;
         objrreltopdelisdevolucoes.AV10Seleca = aP2_Selecao;
         objrreltopdelisdevolucoes.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrreltopdelisdevolucoes.executePrivateCatch ));
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

      private long AV10Seleca ;
      private DateTime AV8DatInic ;
      private DateTime AV9DatFina ;
   }

}
