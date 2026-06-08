/*
               File: LimDependente
        Description: Limitações de dependente.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/1/2026 10:42:0.14
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
   public class plimdependente_wrapper : GXJWin
   {
      public plimdependente_wrapper( int hnd ,
                                     ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class plimdependente : GXWinProcedure
   {
      public plimdependente( int hnd ,
                             ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
      }

      public plimdependente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public plimdependente( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
      }

      public plimdependente( IGxContext context ,
                             int hnd ,
                             ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_Depende )
      {
         this.AV8Depende = aP0_Depende;
         initialize();
         executePrivate();
         aP0_Depende=this.AV8Depende;
      }

      public void executeSubmit( ref short aP0_Depende )
      {
         plimdependente objplimdependente;
         objplimdependente = new plimdependente();
         objplimdependente.AV8Depende = aP0_Depende;
         objplimdependente.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objplimdependente.executePrivateCatch ));
         aP0_Depende=this.AV8Depende;
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
         if ( ( AV8Depende == 0 ) )
         {
            A83Depende = 1 ;
         }
         else
         {
            AV8Depende = 0 ;
         }
         this.cleanup();
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      protected void cleanup( )
      {
         this.AV8Depende = AV8Depende;
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
         A83Depende = 0 ;
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV8Depende ;
      private short A83Depende ;
      private short aP0_Depende ;
   }

}
