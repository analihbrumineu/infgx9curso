/*
               File: VerCidCodigo
        Description: Verificar validade do código da cidade.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:40:33.47
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
   public class pvercidcodigo_wrapper : GXJWin
   {
      public pvercidcodigo_wrapper( int hnd ,
                                    ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class pvercidcodigo : GXWinProcedure
   {
      public pvercidcodigo( int hnd ,
                            ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public pvercidcodigo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public pvercidcodigo( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public pvercidcodigo( IGxContext context ,
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

      public void execute( int aP0_CidCodigo ,
                           out String aP1_Erro )
      {
         this.AV9CidCodi = aP0_CidCodigo;
         this.AV8Erro = "" ;
         initialize();
         executePrivate();
         aP1_Erro=this.AV8Erro;
      }

      public void executeSubmit( int aP0_CidCodigo ,
                                 out String aP1_Erro )
      {
         pvercidcodigo objpvercidcodigo;
         objpvercidcodigo = new pvercidcodigo();
         objpvercidcodigo.AV9CidCodi = aP0_CidCodigo;
         objpvercidcodigo.AV8Erro = "" ;
         objpvercidcodigo.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpvercidcodigo.executePrivateCatch ));
         aP1_Erro=this.AV8Erro;
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
         AV8Erro = "S" ;
         /* Using cursor P00072 */
         pr_default.execute(0, new Object[] {AV9CidCodi});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A26CidCodi = P00072_A26CidCodi[0] ;
            AV8Erro = "N" ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
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
         scmdbuf = "" ;
         P00072_A26CidCodi = new int[1] ;
         A26CidCodi = 0 ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pvercidcodigo__default(),
            new Object[][] {
                new Object[] {
               P00072_A26CidCodi
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int AV9CidCodi ;
      private int A26CidCodi ;
      private String scmdbuf ;
      private String AV8Erro ;
      private IGxDataStore dsDefault ;
      private IDataReader P00072 ;
      private IDataStoreProvider pr_default ;
      private int[] P00072_A26CidCodi ;
      private String aP1_Erro ;
   }

   public class pvercidcodigo__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00072 ;
          prmP00072 = new Object[] {
          new Object[] {"@AV9CidCodi",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("P00072", "SELECT TOP 1 [CidCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @AV9CidCodi ORDER BY [CidCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00072,1,0,false,true )
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
