/*
               File: RelCliComDependente
        Description: Relatório de clientes com dependentes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 9:2:15.40
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
using GeneXus.Printer;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class rrelclicomdependente_wrapper : GXJWin
   {
      public rrelclicomdependente_wrapper( int hnd ,
                                           ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class rrelclicomdependente : GXWinProcedure
   {
      public rrelclicomdependente( int hnd ,
                                   ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public rrelclicomdependente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public rrelclicomdependente( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public rrelclicomdependente( IGxContext context ,
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

      public void execute( int aP0_PesCodInicial ,
                           int aP1_PesCodFinal )
      {
         this.AV9PesCodI = aP0_PesCodInicial;
         this.AV10PesCod = aP1_PesCodFinal;
         initialize();
         executePrivate();
      }

      public void executeSubmit( int aP0_PesCodInicial ,
                                 int aP1_PesCodFinal )
      {
         rrelclicomdependente objrrelclicomdependente;
         objrrelclicomdependente = new rrelclicomdependente();
         objrrelclicomdependente.AV9PesCodI = aP0_PesCodInicial;
         objrrelclicomdependente.AV10PesCod = aP1_PesCodFinal;
         objrrelclicomdependente.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrrelclicomdependente.executePrivateCatch ));
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
         if (askCanceled) return;
         /* GeneXus formulas */
         /* Output device settings */
         M_top = 0 ;
         M_bot = 6 ;
         P_lines = (int)(66-M_bot) ;
         getPrinter().GxClearAttris() ;
         lineHeight = 15 ;
         PrtOffset = 0 ;
         gxXPage = 96 ;
         gxYPage = 96 ;
         try
         {
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 9, 16838, 11906, 0, 1, 1, 0, 1, 1) )
            {
               cleanup();
               return;
            }
            getPrinter().GxSetDocName("Relatório de clientes com dependentes.") ;
            getPrinter().setModal(true) ;
            P_lines = (int)(gxYPage-(lineHeight*6)) ;
            Gx_line = (int)(P_lines+1) ;
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            /* Using cursor R000A2 */
            pr_default.execute(0, new Object[] {AV9PesCodI, AV10PesCod});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A13PesCodi = R000A2_A13PesCodi[0] ;
               A83Depende = R000A2_A83Depende[0] ;
               n83Depende = R000A2_n83Depende[0] ;
               A14PesNome = R000A2_A14PesNome[0] ;
               n14PesNome = R000A2_n14PesNome[0] ;
               A48PesDepT = GetPesDepTotal0( A13PesCodi) ;
               if ( ( A83Depende == 0 ) && ( A48PesDepT != 0 ) )
               {
                  jContext.msgStatus("Acessando clientes...");
                  AV11PesNom = A14PesNome ;
                  H0A0( false, 26) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV11PesNom, "@!")), 39, Gx_line+13, 285, Gx_line+26, 0) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+26) ;
                  AV13CliPes = 0 ;
                  /* Using cursor R000A3 */
                  pr_default.execute(1, new Object[] {A13PesCodi});
                  while ( (pr_default.getStatus(1) != 101) )
                  {
                     A46PesDepC = R000A3_A46PesDepC[0] ;
                     A47PesDepN = R000A3_A47PesDepN[0] ;
                     n47PesDepN = R000A3_n47PesDepN[0] ;
                     A47PesDepN = R000A3_A47PesDepN[0] ;
                     n47PesDepN = R000A3_n47PesDepN[0] ;
                     if ( ( A13PesCodi == A13PesCodi ) )
                     {
                        jContext.msgStatus("Acessando dependentes...");
                        AV14PesDep = A47PesDepN ;
                        H0A0( false, 26) ;
                        getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV14PesDep, "@!")), 234, Gx_line+0, 583, Gx_line+15, 0+256) ;
                        Gx_OldLine = Gx_line ;
                        Gx_line = (int)(Gx_line+26) ;
                     }
                     pr_default.readNext(1);
                  }
                  pr_default.close(1);
                  AV13CliPes = (long)(AV13CliPes+1) ;
               }
               pr_default.readNext(0);
            }
            pr_default.close(0);
            H0A0( false, 39) ;
            getPrinter().GxDrawLine(13, Gx_line+0, 663, Gx_line+0, 1, 100, 100, 100, 0) ;
            getPrinter().GxDrawLine(13, Gx_line+38, 663, Gx_line+38, 1, 100, 100, 100, 0) ;
            getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV13CliPes), "ZZZZZZZZZ9"), 585, Gx_line+13, 654, Gx_line+26, 2) ;
            getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Total de clientes", 468, Gx_line+13, 563, Gx_line+26, 0+256) ;
            Gx_OldLine = Gx_line ;
            Gx_line = (int)(Gx_line+39) ;
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H0A0( true, 0) ;
         }
         catch ( GeneXus.Printer.ProcessInterruptedException e )
         {
         }
         finally
         {
            if ( ( Gx_line > 0 ) )
            {
               /* Close printer file */
               try
               {
                  getPrinter().GxEndPage() ;
                  getPrinter().GxEndDocument() ;
               }
               catch ( GeneXus.Printer.ProcessInterruptedException e )
               {
               }
               endPrinter();
            }
         }
         this.cleanup();
      }

      protected void H0A0( bool bFoot ,
                           int Inc )
      {
         /* Skip the required number of lines */
         while ( ( ToSkip > 0 ) || ( Gx_line + Inc > P_lines ) )
         {
            if ( ( Gx_line + Inc >= P_lines ) )
            {
               if ( ( Gx_page > 0 ) )
               {
                  /* Print footers */
                  Gx_line = P_lines ;
                  getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Rodapé", 312, Gx_line+0, 356, Gx_line+13, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+39) ;
                  if ( ! bFoot )
                  {
                     getPrinter().GxEndPage() ;
                  }
                  if ( bFoot )
                  {
                     return  ;
                  }
               }
               ToSkip = 0 ;
               Gx_line = 0 ;
               Gx_page = (int)(Gx_page+1) ;
               /* Skip Margin Top Lines */
               Gx_line = (int)(Gx_line+(M_top*lineHeight)) ;
               /* Print headers */
               getPrinter().GxStartPage() ;
               getPrinter().GxDrawLine(13, Gx_line+143, 663, Gx_line+143, 1, 100, 100, 100, 0) ;
               getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV17Pgmdes, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 26, Gx_line+39, 324, Gx_line+54, 0) ;
               getPrinter().GxDrawText(StringUtil.Format( Gx_date, "99/99/99"), 598, Gx_line+0, 662, Gx_line+15, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( Gx_time, "XXXXXXXX")), 598, Gx_line+13, 662, Gx_line+28, 0) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(Gx_page), "ZZZZZ9"), 598, Gx_line+26, 649, Gx_line+39, 2) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV9PesCodI), "ZZZZZZZZ9"), 78, Gx_line+65, 140, Gx_line+80, 2+256) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV10PesCod), "ZZZZZZZZ9"), 195, Gx_line+65, 257, Gx_line+80, 2+256) ;
               getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Data:", 559, Gx_line+0, 590, Gx_line+13, 0+256) ;
               getPrinter().GxDrawText("Hora:", 559, Gx_line+13, 590, Gx_line+26, 0+256) ;
               getPrinter().GxDrawText("Página:", 546, Gx_line+26, 589, Gx_line+39, 0+256) ;
               getPrinter().GxDrawText("até", 156, Gx_line+67, 174, Gx_line+80, 0+256) ;
               getPrinter().GxDrawText("Clientes:", 26, Gx_line+67, 75, Gx_line+80, 0+256) ;
               getPrinter().GxDrawText("Cliente", 39, Gx_line+130, 78, Gx_line+143, 0+256) ;
               getPrinter().GxDrawText("Dependente(s)", 234, Gx_line+130, 317, Gx_line+143, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+144) ;
               if (true) break;
            }
            else
            {
               PrtOffset = 0 ;
               Gx_line = (int)(Gx_line+1) ;
            }
            ToSkip = (int)(ToSkip-1) ;
         }
         getPrinter().setPage(Gx_page);
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_RVIEWER_DLL ;
      }

      private bool doAsk( )
      {
         GXAsk ask = new GXAsk( "Relatório de clientes com dependentes." , true , new GXAskObject[] {
         });
         Gx_out = ask.getOutput();
         return ask.getConfirmed();
      }

      protected int GetPesDepTotal0( int E13PesCodi )
      {
         Gx_cnt = 0 ;
         /* Using cursor R000A4 */
         pr_default.execute(2, new Object[] {E13PesCodi});
         if ( (pr_default.getStatus(2) != 101) )
         {
            Gx_cnt = R000A4_Gx_cnt[0] ;
         }
         pr_default.close(2);
         return Gx_cnt ;
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
         askCanceled = false ;
         M_top = 0 ;
         M_bot = 0 ;
         Gx_line = 0 ;
         ToSkip = 0 ;
         PrtOffset = 0 ;
         scmdbuf = "" ;
         R000A2_A13PesCodi = new int[1] ;
         R000A2_A83Depende = new short[1] ;
         R000A2_n83Depende = new bool[] {false} ;
         R000A2_A14PesNome = new String[] {""} ;
         R000A2_n14PesNome = new bool[] {false} ;
         A13PesCodi = 0 ;
         A83Depende = 0 ;
         n83Depende = false ;
         A14PesNome = "" ;
         n14PesNome = false ;
         A48PesDepT = 0 ;
         AV11PesNom = "" ;
         Gx_OldLine = 0 ;
         AV13CliPes = 0 ;
         R000A3_A46PesDepC = new int[1] ;
         R000A3_A13PesCodi = new int[1] ;
         R000A3_A47PesDepN = new String[] {""} ;
         R000A3_n47PesDepN = new bool[] {false} ;
         A46PesDepC = 0 ;
         A47PesDepN = "" ;
         n47PesDepN = false ;
         AV14PesDep = "" ;
         AV17Pgmdes = "" ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         Gx_time = "" ;
         Gx_cnt = 0 ;
         E13PesCodi = 0 ;
         R000A4_Gx_cnt = new int[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rrelclicomdependente__default(),
            new Object[][] {
                new Object[] {
               R000A2_A13PesCodi, R000A2_A83Depende, R000A2_n83Depende, R000A2_A14PesNome, R000A2_n14PesNome
               }
               , new Object[] {
               R000A3_A46PesDepC, R000A3_A13PesCodi, R000A3_A47PesDepN, R000A3_n47PesDepN
               }
               , new Object[] {
               R000A4_Gx_cnt
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         Gx_time = DateTimeUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         AV17Pgmdes = "Relatório de clientes com dependentes." ;
         context.Gx_err = 0 ;
         if ( ( String.CompareOrdinal(Gx_dev.TrimEnd(' '), "S".TrimEnd(' ') ) == 0 ) )
         {
            Gx_out = "PRN" ;
         }
         else
         {
            Gx_out = "SCR" ;
         }
         askCanceled = !doAsk();
      }

      private short A83Depende ;
      private int AV9PesCodI ;
      private int AV10PesCod ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A13PesCodi ;
      private int A48PesDepT ;
      private int Gx_OldLine ;
      private int A46PesDepC ;
      private int Gx_cnt ;
      private int E13PesCodi ;
      private long AV13CliPes ;
      private String scmdbuf ;
      private String AV17Pgmdes ;
      private String Gx_time ;
      private DateTime Gx_date ;
      private bool askCanceled ;
      private bool n83Depende ;
      private bool n14PesNome ;
      private bool n47PesDepN ;
      private String A14PesNome ;
      private String AV11PesNom ;
      private String A47PesDepN ;
      private String AV14PesDep ;
      private IGxDataStore dsDefault ;
      private IDataReader R000A2 ;
      private IDataStoreProvider pr_default ;
      private int[] R000A2_A13PesCodi ;
      private short[] R000A2_A83Depende ;
      private bool[] R000A2_n83Depende ;
      private String[] R000A2_A14PesNome ;
      private bool[] R000A2_n14PesNome ;
      private IDataReader R000A3 ;
      private int[] R000A3_A46PesDepC ;
      private int[] R000A3_A13PesCodi ;
      private String[] R000A3_A47PesDepN ;
      private bool[] R000A3_n47PesDepN ;
      private IDataReader R000A4 ;
      private int[] R000A4_Gx_cnt ;
   }

   public class rrelclicomdependente__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmR000A2 ;
          prmR000A2 = new Object[] {
          new Object[] {"@AV9PesCodI",SqlDbType.Int,9,0} ,
          new Object[] {"@AV10PesCod",SqlDbType.Int,9,0}
          } ;
          Object[] prmR000A3 ;
          prmR000A3 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmR000A4 ;
          prmR000A4 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("R000A2", "SELECT [PesCodigo], [Depende], [PesNome] FROM [PESSOA] WITH (NOLOCK) WHERE ([PesCodigo] >= @AV9PesCodI) AND ([PesCodigo] <= @AV10PesCod) ORDER BY [PesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR000A2,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("R000A3", "SELECT T1.[PesDepCodigo] AS PesDepCodigo, T1.[PesCodigo], T2.[PesNome] AS PesDepNome FROM ([CLIENTEDEPENDENTE] T1 WITH (NOLOCK) INNER JOIN [PESSOA] T2 WITH (NOLOCK) ON T2.[PesCodigo] = T1.[PesDepCodigo]) WHERE T1.[PesCodigo] = @PesCodigo ORDER BY T2.[PesNome] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR000A3,100,0,false,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("R000A4", "SELECT COUNT(*) FROM [CLIENTEDEPENDENTE] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR000A4,1,0,true,true )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                break;
             case 2 :
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
