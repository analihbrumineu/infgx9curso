/*
               File: VerPesFunLogin
        Description: Verificar login do funcionário.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 9:2:15.36
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
   public class pverpesfunlogin_wrapper : GXJWin
   {
      public pverpesfunlogin_wrapper( int hnd ,
                                      ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class pverpesfunlogin : GXWinProcedure
   {
      public pverpesfunlogin( int hnd ,
                              ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public pverpesfunlogin( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public pverpesfunlogin( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public pverpesfunlogin( IGxContext context ,
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

      public void execute( String aP0_PesFunLogin ,
                           int aP1_PesCodigo ,
                           out String aP2_Erro )
      {
         this.A43PesFunL = aP0_PesFunLogin;
         this.AV9PesCodi = aP1_PesCodigo;
         this.AV8Erro = "" ;
         initialize();
         executePrivate();
         aP2_Erro=this.AV8Erro;
      }

      public void executeSubmit( String aP0_PesFunLogin ,
                                 int aP1_PesCodigo ,
                                 out String aP2_Erro )
      {
         pverpesfunlogin objpverpesfunlogin;
         objpverpesfunlogin = new pverpesfunlogin();
         objpverpesfunlogin.A43PesFunL = aP0_PesFunLogin;
         objpverpesfunlogin.AV9PesCodi = aP1_PesCodigo;
         objpverpesfunlogin.AV8Erro = "" ;
         objpverpesfunlogin.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpverpesfunlogin.executePrivateCatch ));
         aP2_Erro=this.AV8Erro;
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
         AV8Erro = "N" ;
         AV15GXLvl2 = 0 ;
         /* Using cursor P00022 */
         pr_default.execute(0, new Object[] {AV9PesCodi, AV10PesFun});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A13PesCodi = P00022_A13PesCodi[0] ;
            AV15GXLvl2 = 1 ;
            AV8Erro = "S" ;
            AV12Ret = GXUtil.SetUserId( A43PesFunL, context, "DEFAULT") ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( ( AV15GXLvl2 == 0 ) )
         {
            AV12Ret = GXUtil.SetUserId( "", context, "DEFAULT") ;
         }
         this.cleanup();
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      protected void cleanup( )
      {
         this.AV8Erro = AV8Erro;
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
         AV15GXLvl2 = 0 ;
         scmdbuf = "" ;
         AV10PesFun = "" ;
         P00022_A13PesCodi = new int[1] ;
         P00022_A43PesFunL = new String[] {""} ;
         P00022_n43PesFunL = new bool[] {false} ;
         A13PesCodi = 0 ;
         AV12Ret = 0 ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pverpesfunlogin__default(),
            new Object[][] {
                new Object[] {
               P00022_A13PesCodi, P00022_A43PesFunL, P00022_n43PesFunL
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV15GXLvl2 ;
      private int AV9PesCodi ;
      private int A13PesCodi ;
      private long AV12Ret ;
      private String AV8Erro ;
      private String scmdbuf ;
      private String A43PesFunL ;
      private String AV10PesFun ;
      private IGxDataStore dsDefault ;
      private IDataReader P00022 ;
      private IDataStoreProvider pr_default ;
      private int[] P00022_A13PesCodi ;
      private String[] P00022_A43PesFunL ;
      private bool[] P00022_n43PesFunL ;
      private String aP2_Erro ;
   }

   public class pverpesfunlogin__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00022 ;
          prmP00022 = new Object[] {
          new Object[] {"@AV9PesCodi",SqlDbType.Int,9,0} ,
          new Object[] {"@AV10PesFun",SqlDbType.VarChar,20,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("P00022", "SELECT TOP 1 [PesCodigo], [PesFunLogin] FROM [PESSOA] WITH (NOLOCK) WHERE ([PesCodigo] <> @AV9PesCodi) AND ([PesFunLogin] = @AV10PesFun) ORDER BY [PesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00022,100,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
