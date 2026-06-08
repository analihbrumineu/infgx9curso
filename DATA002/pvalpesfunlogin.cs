/*
               File: ValPesFunLogin
        Description: Encontrar funcionário cadastrado.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/8/2026 11:43:13.30
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
   public class pvalpesfunlogin_wrapper : GXJWin
   {
      public pvalpesfunlogin_wrapper( int hnd ,
                                      ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class pvalpesfunlogin : GXWinProcedure
   {
      public pvalpesfunlogin( int hnd ,
                              ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
      }

      public pvalpesfunlogin( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public pvalpesfunlogin( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
      }

      public pvalpesfunlogin( IGxContext context ,
                              int hnd ,
                              ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_Logar )
      {
         this.AV10Logar = "" ;
         initialize();
         executePrivate();
         aP0_Logar=this.AV10Logar;
      }

      public void executeSubmit( out String aP0_Logar )
      {
         pvalpesfunlogin objpvalpesfunlogin;
         objpvalpesfunlogin = new pvalpesfunlogin();
         objpvalpesfunlogin.AV10Logar = "" ;
         objpvalpesfunlogin.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpvalpesfunlogin.executePrivateCatch ));
         aP0_Logar=this.AV10Logar;
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
         new wlogin(context, remoteHandle, jContext ).execute( out  AV10Logar) ;
         this.cleanup();
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      protected void cleanup( )
      {
         this.AV10Logar = AV10Logar;
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

      private String AV10Logar ;
      private String aP0_Logar ;
   }

}
