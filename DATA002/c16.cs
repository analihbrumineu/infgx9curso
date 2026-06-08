/*
               File: C16
        Description: Conversion for table LOCACAOLOCACAOMIDIA
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 5/26/2026 10:7:8.28
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
   public class c16_wrapper : GXJWin
   {
      public c16_wrapper( int hnd ,
                          ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class c16 : GXWinProcedure
   {
      public c16( int hnd ,
                  ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public c16( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public c16( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public c16( IGxContext context ,
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

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         c16 objc16;
         objc16 = new c16();
         objc16.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objc16.executePrivateCatch ));
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
         /* Using cursor C162 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A110LocMid = C162_A110LocMid[0] ;
            n110LocMid = C162_n110LocMid[0] ;
            A108LocMid = C162_A108LocMid[0] ;
            n108LocMid = C162_n108LocMid[0] ;
            A106LocMid = C162_A106LocMid[0] ;
            n106LocMid = C162_n106LocMid[0] ;
            A105LocMid = C162_A105LocMid[0] ;
            n105LocMid = C162_n105LocMid[0] ;
            A104LocMid = C162_A104LocMid[0] ;
            n104LocMid = C162_n104LocMid[0] ;
            A103LocMid = C162_A103LocMid[0] ;
            n103LocMid = C162_n103LocMid[0] ;
            A102LocMid = C162_A102LocMid[0] ;
            A86LocCodi = C162_A86LocCodi[0] ;
            /*
               INSERT RECORD ON TABLE GXA0016

            */
            AV2LocCodi = A86LocCodi ;
            AV3LocMidM = A102LocMid ;
            if ( C162_n103LocMid[0] )
            {
               AV4LocMidF = 0 ;
               nV4LocMidF = false ;
               nV4LocMidF = true ;
            }
            else
            {
               AV4LocMidF = A103LocMid ;
               nV4LocMidF = false ;
            }
            if ( C162_n104LocMid[0] )
            {
               AV5LocMidF = "" ;
               nV5LocMidF = false ;
               nV5LocMidF = true ;
            }
            else
            {
               AV5LocMidF = A104LocMid ;
               nV5LocMidF = false ;
            }
            if ( C162_n105LocMid[0] )
            {
               AV6LocMidC = 0 ;
               nV6LocMidC = false ;
               nV6LocMidC = true ;
            }
            else
            {
               AV6LocMidC = A105LocMid ;
               nV6LocMidC = false ;
            }
            if ( C162_n106LocMid[0] )
            {
               AV7LocMidM = 0 ;
               nV7LocMidM = false ;
               nV7LocMidM = true ;
            }
            else
            {
               AV7LocMidM = A106LocMid ;
               nV7LocMidM = false ;
            }
            if ( C162_n108LocMid[0] )
            {
               AV8LocMidM = 0 ;
               nV8LocMidM = false ;
               nV8LocMidM = true ;
            }
            else
            {
               AV8LocMidM = A108LocMid ;
               nV8LocMidM = false ;
            }
            if ( C162_n110LocMid[0] )
            {
               AV9LocMidL = (decimal)(0M) ;
               nV9LocMidL = false ;
               nV9LocMidL = true ;
            }
            else
            {
               AV9LocMidL = A110LocMid ;
               nV9LocMidL = false ;
            }
            /* Using cursor C163 */
            pr_default.execute(1, new Object[] {AV2LocCodi, AV3LocMidM, nV4LocMidF, AV4LocMidF, nV5LocMidF, AV5LocMidF, nV6LocMidC, AV6LocMidC, nV7LocMidM, AV7LocMidM, nV8LocMidM, AV8LocMidM, nV9LocMidL, AV9LocMidL});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         scmdbuf = "" ;
         C162_A110LocMid = new decimal[1] ;
         C162_n110LocMid = new bool[] {false} ;
         C162_A108LocMid = new int[1] ;
         C162_n108LocMid = new bool[] {false} ;
         C162_A106LocMid = new short[1] ;
         C162_n106LocMid = new bool[] {false} ;
         C162_A105LocMid = new int[1] ;
         C162_n105LocMid = new bool[] {false} ;
         C162_A104LocMid = new String[] {""} ;
         C162_n104LocMid = new bool[] {false} ;
         C162_A103LocMid = new int[1] ;
         C162_n103LocMid = new bool[] {false} ;
         C162_A102LocMid = new int[1] ;
         C162_A86LocCodi = new int[1] ;
         A110LocMid = (decimal)(0M) ;
         n110LocMid = false ;
         A108LocMid = 0 ;
         n108LocMid = false ;
         A106LocMid = 0 ;
         n106LocMid = false ;
         A105LocMid = 0 ;
         n105LocMid = false ;
         A104LocMid = "" ;
         n104LocMid = false ;
         A103LocMid = 0 ;
         n103LocMid = false ;
         A102LocMid = 0 ;
         A86LocCodi = 0 ;
         GIGXA0016 = 0 ;
         AV2LocCodi = 0 ;
         AV3LocMidM = 0 ;
         AV4LocMidF = 0 ;
         nV4LocMidF = false ;
         AV5LocMidF = "" ;
         nV5LocMidF = false ;
         AV6LocMidC = 0 ;
         nV6LocMidC = false ;
         AV7LocMidM = 0 ;
         nV7LocMidM = false ;
         AV8LocMidM = 0 ;
         nV8LocMidM = false ;
         AV9LocMidL = (decimal)(0M) ;
         nV9LocMidL = false ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.c16__default(),
            new Object[][] {
                new Object[] {
               C162_A110LocMid, C162_n110LocMid, C162_A108LocMid, C162_n108LocMid, C162_A106LocMid, C162_n106LocMid, C162_A105LocMid, C162_n105LocMid, C162_A104LocMid, C162_n104LocMid,
               C162_A103LocMid, C162_n103LocMid, C162_A102LocMid, C162_A86LocCodi
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A106LocMid ;
      private short AV7LocMidM ;
      private int A108LocMid ;
      private int A105LocMid ;
      private int A103LocMid ;
      private int A102LocMid ;
      private int A86LocCodi ;
      private int GIGXA0016 ;
      private int AV2LocCodi ;
      private int AV3LocMidM ;
      private int AV4LocMidF ;
      private int AV6LocMidC ;
      private int AV8LocMidM ;
      private decimal A110LocMid ;
      private decimal AV9LocMidL ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private bool n110LocMid ;
      private bool n108LocMid ;
      private bool n106LocMid ;
      private bool n105LocMid ;
      private bool n104LocMid ;
      private bool n103LocMid ;
      private bool nV4LocMidF ;
      private bool nV5LocMidF ;
      private bool nV6LocMidC ;
      private bool nV7LocMidM ;
      private bool nV8LocMidM ;
      private bool nV9LocMidL ;
      private String A104LocMid ;
      private String AV5LocMidF ;
      private IGxDataStore dsDefault ;
      private IDataReader C162 ;
      private IDataStoreProvider pr_default ;
      private decimal[] C162_A110LocMid ;
      private bool[] C162_n110LocMid ;
      private int[] C162_A108LocMid ;
      private bool[] C162_n108LocMid ;
      private short[] C162_A106LocMid ;
      private bool[] C162_n106LocMid ;
      private int[] C162_A105LocMid ;
      private bool[] C162_n105LocMid ;
      private String[] C162_A104LocMid ;
      private bool[] C162_n104LocMid ;
      private int[] C162_A103LocMid ;
      private bool[] C162_n103LocMid ;
      private int[] C162_A102LocMid ;
      private int[] C162_A86LocCodi ;
   }

   public class c16__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmC162 ;
          prmC162 = new Object[] {
          } ;
          Object[] prmC163 ;
          prmC163 = new Object[] {
          new Object[] {"@AV2LocCodi",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3LocMidM",SqlDbType.Int,9,0} ,
          new Object[] {"@AV4LocMidF",SqlDbType.Int,9,0} ,
          new Object[] {"@AV5LocMidF",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV6LocMidC",SqlDbType.Int,9,0} ,
          new Object[] {"@AV7LocMidM",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV8LocMidM",SqlDbType.Int,9,0} ,
          new Object[] {"@AV9LocMidL",SqlDbType.Decimal,12,2}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("C162", "SELECT [LocMidLocMidValor], [LocMidMidLocCodigo], [LocMidMidTipo], [LocMidCatCodigo], [LocMidFilNome], [LocMidFilCodigo], [LocMidMidCodigo], [LocCodigo] FROM [LOCACAOLOCACAOMIDIA] WITH (NOLOCK) ORDER BY [LocCodigo], [LocMidMidCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmC162,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("C163", "INSERT INTO [GXA0016] ([LocCodigo], [LocMidMidCodigo], [LocMidFilCodigo], [LocMidFilNome], [LocMidCatCodigo], [LocMidMidTipo], [LocMidMidLocCodigo], [LocMidLocMidValor]) VALUES (@AV2LocCodi, @AV3LocMidM, @AV4LocMidF, @AV5LocMidF, @AV6LocMidC, @AV7LocMidM, @AV8LocMidM, @AV9LocMidL)", GxErrorMask.GX_NOMASK,prmC163)
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((int[]) buf[6])[0] = rslt.getInt(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((int[]) buf[10])[0] = rslt.getInt(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((int[]) buf[12])[0] = rslt.getInt(7) ;
                ((int[]) buf[13])[0] = rslt.getInt(8) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(3, (int)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 7 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(7, (int)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 8 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(8, (decimal)parms[13]);
                }
                break;
       }
    }

 }

}
