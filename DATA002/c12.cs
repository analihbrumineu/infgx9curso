/*
               File: C12
        Description: Conversion for table LOCACAO
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 5/29/2026 11:18:11.57
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
   public class c12_wrapper : GXJWin
   {
      public c12_wrapper( int hnd ,
                          ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class c12 : GXWinProcedure
   {
      public c12( int hnd ,
                  ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public c12( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public c12( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public c12( IGxContext context ,
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
         c12 objc12;
         objc12 = new c12();
         objc12.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objc12.executePrivateCatch ));
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0012] ON "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         /* Using cursor C122 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A93LocVenP = C122_A93LocVenP[0] ;
            n93LocVenP = C122_n93LocVenP[0] ;
            A91LocCliP = C122_A91LocCliP[0] ;
            n91LocCliP = C122_n91LocCliP[0] ;
            A90LocDatC = C122_A90LocDatC[0] ;
            n90LocDatC = C122_n90LocDatC[0] ;
            A89LocDatD = C122_A89LocDatD[0] ;
            n89LocDatD = C122_n89LocDatD[0] ;
            A88LocDatL = C122_A88LocDatL[0] ;
            n88LocDatL = C122_n88LocDatL[0] ;
            A87LocSitu = C122_A87LocSitu[0] ;
            n87LocSitu = C122_n87LocSitu[0] ;
            A86LocCodi = C122_A86LocCodi[0] ;
            /*
               INSERT RECORD ON TABLE GXA0012

            */
            AV2LocCodi = A86LocCodi ;
            if ( C122_n87LocSitu[0] )
            {
               AV3LocSitu = 0 ;
               nV3LocSitu = false ;
               nV3LocSitu = true ;
            }
            else
            {
               AV3LocSitu = A87LocSitu ;
               nV3LocSitu = false ;
            }
            if ( C122_n88LocDatL[0] )
            {
               AV4LocDatL = (DateTime)(DateTime.MinValue) ;
               nV4LocDatL = false ;
               nV4LocDatL = true ;
            }
            else
            {
               AV4LocDatL = A88LocDatL ;
               nV4LocDatL = false ;
            }
            if ( C122_n89LocDatD[0] )
            {
               AV5LocDatD = (DateTime)(DateTime.MinValue) ;
               nV5LocDatD = false ;
               nV5LocDatD = true ;
            }
            else
            {
               AV5LocDatD = A89LocDatD ;
               nV5LocDatD = false ;
            }
            if ( C122_n90LocDatC[0] )
            {
               AV6LocDatC = (DateTime)(DateTime.MinValue) ;
               nV6LocDatC = false ;
               nV6LocDatC = true ;
            }
            else
            {
               AV6LocDatC = A90LocDatC ;
               nV6LocDatC = false ;
            }
            if ( C122_n91LocCliP[0] )
            {
               AV7LocCliP = 0 ;
               nV7LocCliP = false ;
               nV7LocCliP = true ;
            }
            else
            {
               AV7LocCliP = A91LocCliP ;
               nV7LocCliP = false ;
            }
            if ( C122_n93LocVenP[0] )
            {
               AV8LocVenP = 0 ;
               nV8LocVenP = false ;
               nV8LocVenP = true ;
            }
            else
            {
               AV8LocVenP = A93LocVenP ;
               nV8LocVenP = false ;
            }
            /* Using cursor C123 */
            pr_default.execute(1, new Object[] {AV2LocCodi, nV3LocSitu, AV3LocSitu, nV4LocDatL, AV4LocDatL, nV5LocDatD, AV5LocDatD, nV6LocDatC, AV6LocDatC, nV7LocCliP, AV7LocCliP, nV8LocVenP, AV8LocVenP});
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0012] OFF "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
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
         cmdBuffer = "" ;
         scmdbuf = "" ;
         C122_A93LocVenP = new int[1] ;
         C122_n93LocVenP = new bool[] {false} ;
         C122_A91LocCliP = new int[1] ;
         C122_n91LocCliP = new bool[] {false} ;
         C122_A90LocDatC = new DateTime[] {DateTime.MinValue} ;
         C122_n90LocDatC = new bool[] {false} ;
         C122_A89LocDatD = new DateTime[] {DateTime.MinValue} ;
         C122_n89LocDatD = new bool[] {false} ;
         C122_A88LocDatL = new DateTime[] {DateTime.MinValue} ;
         C122_n88LocDatL = new bool[] {false} ;
         C122_A87LocSitu = new short[1] ;
         C122_n87LocSitu = new bool[] {false} ;
         C122_A86LocCodi = new int[1] ;
         A93LocVenP = 0 ;
         n93LocVenP = false ;
         A91LocCliP = 0 ;
         n91LocCliP = false ;
         A90LocDatC = (DateTime)(DateTime.MinValue) ;
         n90LocDatC = false ;
         A89LocDatD = (DateTime)(DateTime.MinValue) ;
         n89LocDatD = false ;
         A88LocDatL = (DateTime)(DateTime.MinValue) ;
         n88LocDatL = false ;
         A87LocSitu = 0 ;
         n87LocSitu = false ;
         A86LocCodi = 0 ;
         GIGXA0012 = 0 ;
         AV2LocCodi = 0 ;
         AV3LocSitu = 0 ;
         nV3LocSitu = false ;
         AV4LocDatL = (DateTime)(DateTime.MinValue) ;
         nV4LocDatL = false ;
         AV5LocDatD = (DateTime)(DateTime.MinValue) ;
         nV5LocDatD = false ;
         AV6LocDatC = (DateTime)(DateTime.MinValue) ;
         nV6LocDatC = false ;
         AV7LocCliP = 0 ;
         nV7LocCliP = false ;
         AV8LocVenP = 0 ;
         nV8LocVenP = false ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.c12__default(),
            new Object[][] {
                new Object[] {
               C122_A93LocVenP, C122_n93LocVenP, C122_A91LocCliP, C122_n91LocCliP, C122_A90LocDatC, C122_n90LocDatC, C122_A89LocDatD, C122_n89LocDatD, C122_A88LocDatL, C122_n88LocDatL,
               C122_A87LocSitu, C122_n87LocSitu, C122_A86LocCodi
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A87LocSitu ;
      private short AV3LocSitu ;
      private int A93LocVenP ;
      private int A91LocCliP ;
      private int A86LocCodi ;
      private int GIGXA0012 ;
      private int AV2LocCodi ;
      private int AV7LocCliP ;
      private int AV8LocVenP ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A90LocDatC ;
      private DateTime A89LocDatD ;
      private DateTime A88LocDatL ;
      private DateTime AV4LocDatL ;
      private DateTime AV5LocDatD ;
      private DateTime AV6LocDatC ;
      private bool n93LocVenP ;
      private bool n91LocCliP ;
      private bool n90LocDatC ;
      private bool n89LocDatD ;
      private bool n88LocDatL ;
      private bool n87LocSitu ;
      private bool nV3LocSitu ;
      private bool nV4LocDatL ;
      private bool nV5LocDatD ;
      private bool nV6LocDatC ;
      private bool nV7LocCliP ;
      private bool nV8LocVenP ;
      private IGxDataStore dsDefault ;
      private GxCommand RGZ ;
      private IDataReader C122 ;
      private IDataStoreProvider pr_default ;
      private int[] C122_A93LocVenP ;
      private bool[] C122_n93LocVenP ;
      private int[] C122_A91LocCliP ;
      private bool[] C122_n91LocCliP ;
      private DateTime[] C122_A90LocDatC ;
      private bool[] C122_n90LocDatC ;
      private DateTime[] C122_A89LocDatD ;
      private bool[] C122_n89LocDatD ;
      private DateTime[] C122_A88LocDatL ;
      private bool[] C122_n88LocDatL ;
      private short[] C122_A87LocSitu ;
      private bool[] C122_n87LocSitu ;
      private int[] C122_A86LocCodi ;
   }

   public class c12__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmC122 ;
          prmC122 = new Object[] {
          } ;
          Object[] prmC123 ;
          prmC123 = new Object[] {
          new Object[] {"@AV2LocCodi",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3LocSitu",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV4LocDatL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV5LocDatD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV6LocDatC",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV7LocCliP",SqlDbType.Int,9,0} ,
          new Object[] {"@AV8LocVenP",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("C122", "SELECT [LocVenPesCodigo], [LocCliPesCodigo], [LocDatCancelamento], [LocDatDevolucao], [LocDatLocacao], [LocSituacao], [LocCodigo] FROM [LOCACAO] WITH (NOLOCK) ORDER BY [LocCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmC122,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("C123", "INSERT INTO [GXA0012] ([LocCodigo], [LocSituacao], [LocDatLocacao], [LocDatDevolucao], [LocDatCancelamento], [LocCliPesCodigo], [LocVenPesCodigo]) VALUES (@AV2LocCodi, @AV3LocSitu, @AV4LocDatL, @AV5LocDatD, @AV6LocDatC, @AV7LocCliP, @AV8LocVenP)", GxErrorMask.GX_NOMASK,prmC123)
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((short[]) buf[10])[0] = rslt.getShort(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((int[]) buf[12])[0] = rslt.getInt(7) ;
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
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[2]);
                }
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(5, (DateTime)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(7, (int)parms[12]);
                }
                break;
       }
    }

 }

}
