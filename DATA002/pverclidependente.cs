/*
               File: VerCliDependente
        Description: Verificar cliente dependente.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 9:2:15.33
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
   public class pverclidependente_wrapper : GXJWin
   {
      public pverclidependente_wrapper( int hnd ,
                                        ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class pverclidependente : GXWinProcedure
   {
      public pverclidependente( int hnd ,
                                ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public pverclidependente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public pverclidependente( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public pverclidependente( IGxContext context ,
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

      public void execute( int aP0_Pescodigo ,
                           out String aP1_Validacao )
      {
         this.AV9Pescodi = aP0_Pescodigo;
         this.AV8Validac = "" ;
         initialize();
         executePrivate();
         aP1_Validacao=this.AV8Validac;
      }

      public void executeSubmit( int aP0_Pescodigo ,
                                 out String aP1_Validacao )
      {
         pverclidependente objpverclidependente;
         objpverclidependente = new pverclidependente();
         objpverclidependente.AV9Pescodi = aP0_Pescodigo;
         objpverclidependente.AV8Validac = "" ;
         objpverclidependente.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpverclidependente.executePrivateCatch ));
         aP1_Validacao=this.AV8Validac;
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
         AV8Validac = "N" ;
         /* Using cursor P00082 */
         pr_default.execute(0, new Object[] {AV9Pescodi});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A83Depende = P00082_A83Depende[0] ;
            n83Depende = P00082_n83Depende[0] ;
            A13PesCodi = P00082_A13PesCodi[0] ;
            AV8Validac = "S" ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         A112DepVal = AV8Validac ;
         this.cleanup();
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      protected void cleanup( )
      {
         this.AV8Validac = AV8Validac;
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
         P00082_A83Depende = new short[1] ;
         P00082_n83Depende = new bool[] {false} ;
         P00082_A13PesCodi = new int[1] ;
         A83Depende = 0 ;
         n83Depende = false ;
         A13PesCodi = 0 ;
         A112DepVal = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pverclidependente__default(),
            new Object[][] {
                new Object[] {
               P00082_A83Depende, P00082_n83Depende, P00082_A13PesCodi
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A83Depende ;
      private int AV9Pescodi ;
      private int A13PesCodi ;
      private String scmdbuf ;
      private bool n83Depende ;
      private String AV8Validac ;
      private String A112DepVal ;
      private IGxDataStore dsDefault ;
      private IDataReader P00082 ;
      private IDataStoreProvider pr_default ;
      private short[] P00082_A83Depende ;
      private bool[] P00082_n83Depende ;
      private int[] P00082_A13PesCodi ;
      private String aP1_Validacao ;
   }

   public class pverclidependente__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00082 ;
          prmP00082 = new Object[] {
          new Object[] {"@AV9Pescodi",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("P00082", "SELECT TOP 1 [Depende], [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE ([PesCodigo] = @AV9Pescodi) AND ([Depende] = 1) ORDER BY [PesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00082,1,0,false,true )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
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
