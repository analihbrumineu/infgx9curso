/*
               File: GXRTCtls
        Description: Run time reorganization controls
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/12/2026 10:21:20.95
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
using com.genexus;
using com.genexus.ui;
using com.genexus.uifactory;
using GeneXus.Windows;
using System.Data;
using System.Data.SqlClient;
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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class gxrtctls_wrapper : GXJWin
   {
      public gxrtctls_wrapper( int hnd ,
                               ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class gxrtctls : GXWinProcedure
   {
      public gxrtctls( int hnd ,
                       ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public gxrtctls( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public gxrtctls( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public gxrtctls( IGxContext context ,
                       int hnd ,
                       ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_Status )
      {
         this.AV2Status = aP0_Status;
         initialize();
         executePrivate();
         aP0_Status=this.AV2Status;
      }

      public void executeSubmit( ref short aP0_Status )
      {
         gxrtctls objgxrtctls;
         objgxrtctls = new gxrtctls();
         objgxrtctls.AV2Status = aP0_Status;
         objgxrtctls.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objgxrtctls.executePrivateCatch ));
         aP0_Status=this.AV2Status;
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
         AV2Status = 0 ;
         GeneXus.Reorg.GXReorganization.AddMsg( "=== Starting run time controls" , null);
         GeneXus.Reorg.GXReorganization.AddMsg( "Checking that table CIDADE does NOT contain records." , null);
         AV5GXLvl3 = 0 ;
         /* Using cursor LTCtls2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A26CidCodi = LTCtls2_A26CidCodi[0] ;
            AV5GXLvl3 = 1 ;
            GeneXus.Reorg.GXReorganization.AddMsg( "Checking existance of referenced key value in table ESTADO." , null);
            AV6GXLvl6 = 0 ;
            /* Using cursor LTCtls3 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               A24EstCodi = LTCtls3_A24EstCodi[0] ;
               if ( ( A24EstCodi == 0 ) )
               {
                  AV6GXLvl6 = 1 ;
                  GeneXus.Reorg.GXReorganization.AddMsg( "Success: Table CIDADEhas records but referenced key value in table ESTADO exist." , null);
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               pr_default.readNext(1);
            }
            pr_default.close(1);
            if ( ( AV6GXLvl6 == 0 ) )
            {
               AV2Status = 1 ;
               GeneXus.Reorg.GXReorganization.AddMsg( "Fail: Table CIDADE has records but referenced key value in table ESTADO does _not_ exist." , null);
               GeneXus.Reorg.GXReorganization.AddMsg( "Recovery: See recovery information for reorganization message rgz0029." , null);
            }
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( ( AV5GXLvl3 == 0 ) )
         {
            GeneXus.Reorg.GXReorganization.AddMsg( "Success: Table CIDADE does NOT have records." , null);
         }
         GeneXus.Reorg.GXReorganization.AddMsg( "====================" , null);
         GeneXus.Reorg.GXReorganization.AddMsg( "=== End of run time controls" , null);
         this.cleanup();
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      protected void cleanup( )
      {
         this.AV2Status = AV2Status;
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
         AV5GXLvl3 = 0 ;
         scmdbuf = "" ;
         LTCtls2_A26CidCodi = new int[1] ;
         A26CidCodi = 0 ;
         AV6GXLvl6 = 0 ;
         LTCtls3_A24EstCodi = new int[1] ;
         A24EstCodi = 0 ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gxrtctls__default(),
            new Object[][] {
                new Object[] {
               LTCtls2_A26CidCodi
               }
               , new Object[] {
               LTCtls3_A24EstCodi
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV2Status ;
      private short AV5GXLvl3 ;
      private short AV6GXLvl6 ;
      private int A26CidCodi ;
      private int A24EstCodi ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private short aP0_Status ;
      private IDataReader LTCtls2 ;
      private IDataStoreProvider pr_default ;
      private int[] LTCtls2_A26CidCodi ;
      private IDataReader LTCtls3 ;
      private int[] LTCtls3_A24EstCodi ;
   }

   public class gxrtctls__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmLTCtls2 ;
          prmLTCtls2 = new Object[] {
          } ;
          Object[] prmLTCtls3 ;
          prmLTCtls3 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("LTCtls2", "SELECT TOP 1 [CidCodigo] FROM [CIDADE] WITH (NOLOCK) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmLTCtls2,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("LTCtls3", "SELECT TOP 1 [EstCodigo] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = 0 ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmLTCtls3,100,0,false,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
