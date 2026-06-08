/*
               File: ConDeMidia
        Description: Contador de mídia para relatórios.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 5/4/2026 8:16:4.87
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
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class pcondemidia_wrapper : GXJWin
   {
      public pcondemidia_wrapper( int hnd ,
                                  ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class pcondemidia : GXWinProcedure
   {
      public pcondemidia( int hnd ,
                          ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public pcondemidia( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public pcondemidia( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public pcondemidia( IGxContext context ,
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

      public void execute( out long aP0_TotMidia )
      {
         this.AV8TotMidi = 0 ;
         initialize();
         executePrivate();
         aP0_TotMidia=this.AV8TotMidi;
      }

      public void executeSubmit( out long aP0_TotMidia )
      {
         pcondemidia objpcondemidia;
         objpcondemidia = new pcondemidia();
         objpcondemidia.AV8TotMidi = 0 ;
         objpcondemidia.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpcondemidia.executePrivateCatch ));
         aP0_TotMidia=this.AV8TotMidi;
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
         AV8TotMidi = 0 ;
         /* Optimized group. */
         /* Using cursor P000D2 */
         pr_default.execute(0, new Object[] {AV9FilCodi, AV11MidTip});
         cV8TotMidi = P000D2_AV8TotMidi[0] ;
         pr_default.close(0);
         AV8TotMidi = (long)(AV8TotMidi+cV8TotMidi*1) ;
         /* End optimized group. */
         this.cleanup();
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      protected void cleanup( )
      {
         this.AV8TotMidi = AV8TotMidi;
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
         scmdbuf = "" ;
         AV9FilCodi = 0 ;
         AV11MidTip = 0 ;
         P000D2_AV8TotMidi = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pcondemidia__default(),
            new Object[][] {
                new Object[] {
               P000D2_AV8TotMidi
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV11MidTip ;
      private int AV9FilCodi ;
      private long AV8TotMidi ;
      private long cV8TotMidi ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataReader P000D2 ;
      private IDataStoreProvider pr_default ;
      private long[] P000D2_AV8TotMidi ;
      private long aP0_TotMidia ;
   }

   public class pcondemidia__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmP000D2 ;
          prmP000D2 = new Object[] {
          new Object[] {"@AV9FilCodi",SqlDbType.Int,9,0} ,
          new Object[] {"@AV11MidTip",SqlDbType.SmallInt,1,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("P000D2", "SELECT COUNT(*) FROM [MIDIA] WITH (NOLOCK) WHERE ([FilCodigo] = @AV9FilCodi) AND ([MidTipo] = @AV11MidTip) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000D2,1,0,true,false )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
       }
    }

 }

}
