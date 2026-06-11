/*
               File: RetFunLogDados
        Description: Retornar dados do funcionário logado.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 9:2:15.22
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
   public class pretfunlogdados_wrapper : GXJWin
   {
      public pretfunlogdados_wrapper( int hnd ,
                                      ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class pretfunlogdados : GXWinProcedure
   {
      public pretfunlogdados( int hnd ,
                              ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public pretfunlogdados( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public pretfunlogdados( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public pretfunlogdados( IGxContext context ,
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

      public void execute( out SdtSDTFuncionario aP0_Funcionario )
      {
         this.AV9Funcion = new SdtSDTFuncionario(context) ;
         initialize();
         executePrivate();
         aP0_Funcionario=this.AV9Funcion;
      }

      public void executeSubmit( out SdtSDTFuncionario aP0_Funcionario )
      {
         pretfunlogdados objpretfunlogdados;
         objpretfunlogdados = new pretfunlogdados();
         objpretfunlogdados.AV9Funcion = new SdtSDTFuncionario(context) ;
         objpretfunlogdados.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpretfunlogdados.executePrivateCatch ));
         aP0_Funcionario=this.AV9Funcion;
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
         AV9Funcion = new SdtSDTFuncionario(context) ;
         AV8PesFunL = GXUtil.UserId( "", context, "DEFAULT") ;
         if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV8PesFunL).TrimEnd(' ') )==0)) )
         {
            AV9Funcion.gxTpr_Foilogado = "N" ;
         }
         else
         {
            AV9Funcion.gxTpr_Foilogado = "S" ;
            /* Using cursor P000E2 */
            pr_default.execute(0, new Object[] {AV8PesFunL});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A43PesFunL = P000E2_A43PesFunL[0] ;
               n43PesFunL = P000E2_n43PesFunL[0] ;
               A13PesCodi = P000E2_A13PesCodi[0] ;
               A14PesNome = P000E2_A14PesNome[0] ;
               n14PesNome = P000E2_n14PesNome[0] ;
               A39PesFunC = P000E2_A39PesFunC[0] ;
               n39PesFunC = P000E2_n39PesFunC[0] ;
               A44PesFunS = P000E2_A44PesFunS[0] ;
               n44PesFunS = P000E2_n44PesFunS[0] ;
               AV9Funcion.gxTpr_Pescodigo = A13PesCodi ;
               AV9Funcion.gxTpr_Pesnome = A14PesNome ;
               AV9Funcion.gxTpr_Pesfuncargo = A39PesFunC ;
               AV9Funcion.gxTpr_Pesfunlogin = A43PesFunL ;
               AV9Funcion.gxTpr_Pesfunsenha = A44PesFunS ;
               pr_default.readNext(0);
            }
            pr_default.close(0);
         }
         this.cleanup();
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      protected void cleanup( )
      {
         this.AV9Funcion = AV9Funcion;
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
         AV8PesFunL = "" ;
         scmdbuf = "" ;
         P000E2_A43PesFunL = new String[] {""} ;
         P000E2_n43PesFunL = new bool[] {false} ;
         P000E2_A13PesCodi = new int[1] ;
         P000E2_A14PesNome = new String[] {""} ;
         P000E2_n14PesNome = new bool[] {false} ;
         P000E2_A39PesFunC = new short[1] ;
         P000E2_n39PesFunC = new bool[] {false} ;
         P000E2_A44PesFunS = new String[] {""} ;
         P000E2_n44PesFunS = new bool[] {false} ;
         A43PesFunL = "" ;
         n43PesFunL = false ;
         A13PesCodi = 0 ;
         A14PesNome = "" ;
         n14PesNome = false ;
         A39PesFunC = 0 ;
         n39PesFunC = false ;
         A44PesFunS = "" ;
         n44PesFunS = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pretfunlogdados__default(),
            new Object[][] {
                new Object[] {
               P000E2_A43PesFunL, P000E2_n43PesFunL, P000E2_A13PesCodi, P000E2_A14PesNome, P000E2_n14PesNome, P000E2_A39PesFunC, P000E2_n39PesFunC, P000E2_A44PesFunS, P000E2_n44PesFunS
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A39PesFunC ;
      private int A13PesCodi ;
      private String scmdbuf ;
      private bool n43PesFunL ;
      private bool n14PesNome ;
      private bool n39PesFunC ;
      private bool n44PesFunS ;
      private String AV8PesFunL ;
      private String A43PesFunL ;
      private String A14PesNome ;
      private String A44PesFunS ;
      private IGxDataStore dsDefault ;
      private IDataReader P000E2 ;
      private IDataStoreProvider pr_default ;
      private String[] P000E2_A43PesFunL ;
      private bool[] P000E2_n43PesFunL ;
      private int[] P000E2_A13PesCodi ;
      private String[] P000E2_A14PesNome ;
      private bool[] P000E2_n14PesNome ;
      private short[] P000E2_A39PesFunC ;
      private bool[] P000E2_n39PesFunC ;
      private String[] P000E2_A44PesFunS ;
      private bool[] P000E2_n44PesFunS ;
      private SdtSDTFuncionario aP0_Funcionario ;
      private SdtSDTFuncionario AV9Funcion ;
   }

   public class pretfunlogdados__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000E2 ;
          prmP000E2 = new Object[] {
          new Object[] {"@AV8PesFunL",SqlDbType.VarChar,20,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("P000E2", "SELECT [PesFunLogin], [PesCodigo], [PesNome], [PesFunCargo], [PesFunSenha] FROM [PESSOA] WITH (NOLOCK) WHERE [PesFunLogin] = @AV8PesFunL ORDER BY [PesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000E2,100,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
