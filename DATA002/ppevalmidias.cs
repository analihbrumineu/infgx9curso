/*
               File: PeValMidias
        Description: Validar mídias liberadas da locação.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/9/2026 8:48:33.96
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
   public class ppevalmidias_wrapper : GXJWin
   {
      public ppevalmidias_wrapper( int hnd ,
                                   ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class ppevalmidias : GXWinProcedure
   {
      public ppevalmidias( int hnd ,
                           ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public ppevalmidias( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public ppevalmidias( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public ppevalmidias( IGxContext context ,
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

      public void execute( int aP0_LocCodigo ,
                           out String aP1_MsgErro )
      {
         this.AV8LocCodi = aP0_LocCodigo;
         this.AV9MsgErro = "" ;
         initialize();
         executePrivate();
         aP1_MsgErro=this.AV9MsgErro;
      }

      public void executeSubmit( int aP0_LocCodigo ,
                                 out String aP1_MsgErro )
      {
         ppevalmidias objppevalmidias;
         objppevalmidias = new ppevalmidias();
         objppevalmidias.AV8LocCodi = aP0_LocCodigo;
         objppevalmidias.AV9MsgErro = "" ;
         objppevalmidias.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objppevalmidias.executePrivateCatch ));
         aP1_MsgErro=this.AV9MsgErro;
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
         /* Using cursor P000J2 */
         pr_default.execute(0, new Object[] {AV8LocCodi});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A86LocCodi = P000J2_A86LocCodi[0] ;
            A103LocMid = P000J2_A103LocMid[0] ;
            n103LocMid = P000J2_n103LocMid[0] ;
            A107LocMid = P000J2_A107LocMid[0] ;
            n107LocMid = P000J2_n107LocMid[0] ;
            A104LocMid = P000J2_A104LocMid[0] ;
            n104LocMid = P000J2_n104LocMid[0] ;
            A102LocMid = P000J2_A102LocMid[0] ;
            A107LocMid = P000J2_A107LocMid[0] ;
            n107LocMid = P000J2_n107LocMid[0] ;
            if ( ( A107LocMid == 2 ) )
            {
               if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV9MsgErro).TrimEnd(' ') )==0)) )
               {
                  AV9MsgErro = "Locação " + StringUtil.Str( (decimal)(A86LocCodi), 9, 0) + " não pode ser realizada devido a presença de mídia(s) já locada(s)." ;
               }
               AV9MsgErro = AV9MsgErro + StringUtil.NewLine( ) + "Código da mídia = " + StringUtil.Str( (decimal)(A102LocMid), 9, 0) + StringUtil.NewLine( ) + " - Nome da mídia: " + A104LocMid ;
            }
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
         this.AV9MsgErro = AV9MsgErro;
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
         P000J2_A86LocCodi = new int[1] ;
         P000J2_A103LocMid = new int[1] ;
         P000J2_n103LocMid = new bool[] {false} ;
         P000J2_A107LocMid = new short[1] ;
         P000J2_n107LocMid = new bool[] {false} ;
         P000J2_A104LocMid = new String[] {""} ;
         P000J2_n104LocMid = new bool[] {false} ;
         P000J2_A102LocMid = new int[1] ;
         A86LocCodi = 0 ;
         A103LocMid = 0 ;
         n103LocMid = false ;
         A107LocMid = 0 ;
         n107LocMid = false ;
         A104LocMid = "" ;
         n104LocMid = false ;
         A102LocMid = 0 ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ppevalmidias__default(),
            new Object[][] {
                new Object[] {
               P000J2_A86LocCodi, P000J2_A103LocMid, P000J2_n103LocMid, P000J2_A107LocMid, P000J2_n107LocMid, P000J2_A104LocMid, P000J2_n104LocMid, P000J2_A102LocMid
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A107LocMid ;
      private int AV8LocCodi ;
      private int A86LocCodi ;
      private int A103LocMid ;
      private int A102LocMid ;
      private String scmdbuf ;
      private bool n103LocMid ;
      private bool n107LocMid ;
      private bool n104LocMid ;
      private String A104LocMid ;
      private String AV9MsgErro ;
      private IGxDataStore dsDefault ;
      private IDataReader P000J2 ;
      private IDataStoreProvider pr_default ;
      private int[] P000J2_A86LocCodi ;
      private int[] P000J2_A103LocMid ;
      private bool[] P000J2_n103LocMid ;
      private short[] P000J2_A107LocMid ;
      private bool[] P000J2_n107LocMid ;
      private String[] P000J2_A104LocMid ;
      private bool[] P000J2_n104LocMid ;
      private int[] P000J2_A102LocMid ;
      private String aP1_MsgErro ;
   }

   public class ppevalmidias__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000J2 ;
          prmP000J2 = new Object[] {
          new Object[] {"@AV8LocCodi",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("P000J2", "SELECT T1.[LocCodigo], T1.[LocMidFilCodigo], T2.[MidSituacao] AS LocMidMidSituacao, T1.[LocMidFilNome], T1.[LocMidMidCodigo] AS LocMidMidCodigo FROM ([LOCACAOLOCACAOMIDIA] T1 WITH (NOLOCK) INNER JOIN [MIDIA] T2 WITH (NOLOCK) ON T2.[MidCodigo] = T1.[LocMidMidCodigo]) WHERE T1.[LocCodigo] = @AV8LocCodi ORDER BY T1.[LocCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J2,100,0,false,false )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
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
                break;
       }
    }

 }

}
