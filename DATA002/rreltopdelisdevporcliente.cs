/*
               File: RelTopDeLisDevPorCliente
        Description: Relatório de topo de lista sobre total de devoluções por cliente.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 8:22:47.39
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
   public class rreltopdelisdevporcliente_wrapper : GXJWin
   {
      public rreltopdelisdevporcliente_wrapper( int hnd ,
                                                ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class rreltopdelisdevporcliente : GXWinProcedure
   {
      public rreltopdelisdevporcliente( int hnd ,
                                        ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public rreltopdelisdevporcliente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public rreltopdelisdevporcliente( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public rreltopdelisdevporcliente( IGxContext context ,
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

      public void execute( DateTime aP0_DatInicial ,
                           DateTime aP1_DatFinal ,
                           long aP2_Selecao )
      {
         this.AV8DatInic = aP0_DatInicial;
         this.AV9DatFina = aP1_DatFinal;
         this.AV10Seleca = aP2_Selecao;
         initialize();
         executePrivate();
      }

      public void executeSubmit( DateTime aP0_DatInicial ,
                                 DateTime aP1_DatFinal ,
                                 long aP2_Selecao )
      {
         rreltopdelisdevporcliente objrreltopdelisdevporcliente;
         objrreltopdelisdevporcliente = new rreltopdelisdevporcliente();
         objrreltopdelisdevporcliente.AV8DatInic = aP0_DatInicial;
         objrreltopdelisdevporcliente.AV9DatFina = aP1_DatFinal;
         objrreltopdelisdevporcliente.AV10Seleca = aP2_Selecao;
         objrreltopdelisdevporcliente.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrreltopdelisdevporcliente.executePrivateCatch ));
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
            getPrinter().GxSetDocName("Relatório de topo de lista sobre total de devoluções por cliente.") ;
            getPrinter().setModal(true) ;
            P_lines = (int)(gxYPage-(lineHeight*6)) ;
            Gx_line = (int)(P_lines+1) ;
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            AV17AuxLoc = "" ;
            AV24Client = new GxObjectCollection( context, "SDTCliRelatorio.SDTCliDevolucaoItem", "AgoraVaiCurso", "SdtSDTCliRelatorio_SDTCliDevolucaoItem", "GeneXus.Programs") ;
            /* Using cursor R000O2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A89LocDatD = R000O2_A89LocDatD[0] ;
               n89LocDatD = R000O2_n89LocDatD[0] ;
               A91LocCliP = R000O2_A91LocCliP[0] ;
               n91LocCliP = R000O2_n91LocCliP[0] ;
               A92LocCliP = R000O2_A92LocCliP[0] ;
               n92LocCliP = R000O2_n92LocCliP[0] ;
               A92LocCliP = R000O2_A92LocCliP[0] ;
               n92LocCliP = R000O2_n92LocCliP[0] ;
               if ( ( A89LocDatD >= AV8DatInic ) && ( A89LocDatD <= AV9DatFina ) && ( A89LocDatD != DateTimeUtil.CToD( "0", 2) ) )
               {
                  if ( ( String.CompareOrdinal(A92LocCliP.TrimEnd(' '), AV17AuxLoc.TrimEnd(' ') ) != 0 ) )
                  {
                     if ( ( String.CompareOrdinal(AV17AuxLoc.TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
                     {
                        AV24Client.Add(AV25Item, 0);
                     }
                     AV25Item = new SdtSDTCliRelatorio_SDTCliDevolucaoItem(context) ;
                     AV25Item.gxTpr_Clirellocclipescodigo = A91LocCliP ;
                     AV25Item.gxTpr_Clirellocclipesnome = A92LocCliP ;
                     AV25Item.gxTpr_Clireltotal = 0 ;
                     AV17AuxLoc = A92LocCliP ;
                  }
                  AV25Item.gxTpr_Clireltotal = (long)(AV25Item.gxTpr_Clireltotal+1) ;
               }
               pr_default.readNext(0);
            }
            pr_default.close(0);
            if ( ( String.CompareOrdinal(AV17AuxLoc.TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
            {
               AV24Client.Add(AV25Item, 0);
            }
            AV24Client.Sort("[CliRelTotal]");
            AV23ContSe = 0 ;
            AV33GXV1 = 1 ;
            while ( ( AV33GXV1 <= AV24Client.Count ) )
            {
               AV25Item = ((SdtSDTCliRelatorio_SDTCliDevolucaoItem)AV24Client.Item(AV33GXV1)) ;
               if ( ( AV23ContSe < AV10Seleca ) )
               {
                  AV12LocCli = AV25Item.gxTpr_Clirellocclipesnome ;
                  H0O0( false, 39) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV12LocCli, "@!")), 26, Gx_line+13, 246, Gx_line+28, 0) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+39) ;
                  /* Using cursor R000O3 */
                  pr_default.execute(1, new Object[] {AV12LocCli});
                  while ( (pr_default.getStatus(1) != 101) )
                  {
                     A91LocCliP = R000O3_A91LocCliP[0] ;
                     n91LocCliP = R000O3_n91LocCliP[0] ;
                     A89LocDatD = R000O3_A89LocDatD[0] ;
                     n89LocDatD = R000O3_n89LocDatD[0] ;
                     A92LocCliP = R000O3_A92LocCliP[0] ;
                     n92LocCliP = R000O3_n92LocCliP[0] ;
                     A86LocCodi = R000O3_A86LocCodi[0] ;
                     A92LocCliP = R000O3_A92LocCliP[0] ;
                     n92LocCliP = R000O3_n92LocCliP[0] ;
                     if ( ( A89LocDatD >= AV8DatInic ) && ( A89LocDatD <= AV9DatFina ) && ( A89LocDatD != DateTimeUtil.CToD( "0", 2) ) )
                     {
                        AV11LocCod = A86LocCodi ;
                        H0O0( false, 16) ;
                        getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                        getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV11LocCod), "ZZZZZZZZ9"), 260, Gx_line+0, 322, Gx_line+15, 2+256) ;
                        Gx_OldLine = Gx_line ;
                        Gx_line = (int)(Gx_line+16) ;
                     }
                     pr_default.readNext(1);
                  }
                  pr_default.close(1);
                  AV14TotDev = AV25Item.gxTpr_Clireltotal ;
                  H0O0( false, 15) ;
                  getPrinter().GxDrawLine(52, Gx_line+12, 650, Gx_line+12, 1, 200, 200, 200, 0) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV14TotDev), "ZZZZZZZZZ9"), 559, Gx_line+0, 628, Gx_line+15, 2+256) ;
                  getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Total", 507, Gx_line+0, 536, Gx_line+13, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+15) ;
                  AV23ContSe = (long)(AV23ContSe+1) ;
               }
               else
               {
                  if (true) break;
               }
               AV33GXV1 = (int)(AV33GXV1+1) ;
            }
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H0O0( true, 0) ;
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

      protected void H0O0( bool bFoot ,
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
                  getPrinter().GxDrawLine(26, Gx_line+13, 650, Gx_line+13, 1, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Rodape", 325, Gx_line+26, 369, Gx_line+39, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+52) ;
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
               getPrinter().GxDrawLine(26, Gx_line+194, 650, Gx_line+194, 1, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(Gx_page), "ZZZZZ9"), 606, Gx_line+26, 657, Gx_line+41, 2) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV29Pgmdes, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 143, Gx_line+20, 506, Gx_line+35, 0) ;
               getPrinter().GxDrawText(StringUtil.Format( Gx_date, "99/99/99"), 611, Gx_line+0, 666, Gx_line+15, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( Gx_time, "XXXXXXXX")), 611, Gx_line+13, 666, Gx_line+28, 0+256) ;
               getPrinter().GxDrawText(StringUtil.Format( AV8DatInic, "99/99/9999"), 65, Gx_line+91, 134, Gx_line+106, 0+256) ;
               getPrinter().GxDrawText(StringUtil.Format( AV9DatFina, "99/99/9999"), 169, Gx_line+91, 238, Gx_line+106, 0+256) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV10Seleca), "ZZZZZZZZZ9"), 91, Gx_line+117, 160, Gx_line+132, 2+256) ;
               getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Data:", 567, Gx_line+0, 598, Gx_line+13, 0+256) ;
               getPrinter().GxDrawText("Hora:", 567, Gx_line+13, 598, Gx_line+26, 0+256) ;
               getPrinter().GxDrawText("Página:", 554, Gx_line+26, 597, Gx_line+39, 0+256) ;
               getPrinter().GxDrawText("De", 39, Gx_line+91, 55, Gx_line+104, 0+256) ;
               getPrinter().GxDrawText("até", 143, Gx_line+91, 161, Gx_line+104, 0+256) ;
               getPrinter().GxDrawText("Seleção", 39, Gx_line+117, 85, Gx_line+130, 0+256) ;
               getPrinter().GxDrawText("Cliente", 26, Gx_line+182, 65, Gx_line+195, 0+256) ;
               getPrinter().GxDrawText("Locação", 286, Gx_line+182, 335, Gx_line+195, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+195) ;
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
         GXAsk ask = new GXAsk( "Relatório de topo de lista sobre total de devoluções por cliente." , true , new GXAskObject[] {
         });
         Gx_out = ask.getOutput();
         return ask.getConfirmed();
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
         AV17AuxLoc = "" ;
         AV24Client = new GxObjectCollection( context, "SDTCliRelatorio.SDTCliDevolucaoItem", "AgoraVaiCurso", "SdtSDTCliRelatorio_SDTCliDevolucaoItem", "GeneXus.Programs");
         scmdbuf = "" ;
         R000O2_A86LocCodi = new int[1] ;
         R000O2_A89LocDatD = new DateTime[] {DateTime.MinValue} ;
         R000O2_n89LocDatD = new bool[] {false} ;
         R000O2_A91LocCliP = new int[1] ;
         R000O2_n91LocCliP = new bool[] {false} ;
         R000O2_A92LocCliP = new String[] {""} ;
         R000O2_n92LocCliP = new bool[] {false} ;
         A89LocDatD = (DateTime)(DateTime.MinValue) ;
         n89LocDatD = false ;
         A91LocCliP = 0 ;
         n91LocCliP = false ;
         A92LocCliP = "" ;
         n92LocCliP = false ;
         AV25Item = new SdtSDTCliRelatorio_SDTCliDevolucaoItem(context);
         AV23ContSe = 0 ;
         AV33GXV1 = 0 ;
         AV12LocCli = "" ;
         Gx_OldLine = 0 ;
         R000O3_A91LocCliP = new int[1] ;
         R000O3_n91LocCliP = new bool[] {false} ;
         R000O3_A89LocDatD = new DateTime[] {DateTime.MinValue} ;
         R000O3_n89LocDatD = new bool[] {false} ;
         R000O3_A92LocCliP = new String[] {""} ;
         R000O3_n92LocCliP = new bool[] {false} ;
         R000O3_A86LocCodi = new int[1] ;
         A86LocCodi = 0 ;
         AV11LocCod = 0 ;
         AV14TotDev = 0 ;
         AV29Pgmdes = "" ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         Gx_time = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rreltopdelisdevporcliente__default(),
            new Object[][] {
                new Object[] {
               R000O2_A86LocCodi, R000O2_A89LocDatD, R000O2_n89LocDatD, R000O2_A91LocCliP, R000O2_n91LocCliP, R000O2_A92LocCliP, R000O2_n92LocCliP
               }
               , new Object[] {
               R000O3_A91LocCliP, R000O3_n91LocCliP, R000O3_A89LocDatD, R000O3_n89LocDatD, R000O3_A92LocCliP, R000O3_n92LocCliP, R000O3_A86LocCodi
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         Gx_time = DateTimeUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         AV29Pgmdes = "Relatório de topo de lista sobre total de devoluções por cliente." ;
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

      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A91LocCliP ;
      private int AV33GXV1 ;
      private int Gx_OldLine ;
      private int A86LocCodi ;
      private int AV11LocCod ;
      private long AV10Seleca ;
      private long AV23ContSe ;
      private long AV14TotDev ;
      private String scmdbuf ;
      private String AV29Pgmdes ;
      private String Gx_time ;
      private DateTime AV8DatInic ;
      private DateTime AV9DatFina ;
      private DateTime A89LocDatD ;
      private DateTime Gx_date ;
      private bool askCanceled ;
      private bool n89LocDatD ;
      private bool n91LocCliP ;
      private bool n92LocCliP ;
      private String AV17AuxLoc ;
      private String A92LocCliP ;
      private String AV12LocCli ;
      private IGxDataStore dsDefault ;
      private IDataReader R000O2 ;
      private IDataStoreProvider pr_default ;
      private int[] R000O2_A86LocCodi ;
      private DateTime[] R000O2_A89LocDatD ;
      private bool[] R000O2_n89LocDatD ;
      private int[] R000O2_A91LocCliP ;
      private bool[] R000O2_n91LocCliP ;
      private String[] R000O2_A92LocCliP ;
      private bool[] R000O2_n92LocCliP ;
      private IDataReader R000O3 ;
      private int[] R000O3_A91LocCliP ;
      private bool[] R000O3_n91LocCliP ;
      private DateTime[] R000O3_A89LocDatD ;
      private bool[] R000O3_n89LocDatD ;
      private String[] R000O3_A92LocCliP ;
      private bool[] R000O3_n92LocCliP ;
      private int[] R000O3_A86LocCodi ;
      private GxObjectCollection AV24Client ;
      private SdtSDTCliRelatorio_SDTCliDevolucaoItem AV25Item ;
   }

   public class rreltopdelisdevporcliente__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmR000O2 ;
          prmR000O2 = new Object[] {
          } ;
          Object[] prmR000O3 ;
          prmR000O3 = new Object[] {
          new Object[] {"@AV12LocCli",SqlDbType.VarChar,50,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("R000O2", "SELECT T1.[LocCodigo], T1.[LocDatDevolucao], T1.[LocCliPesCodigo] AS LocCliPesCodigo, T2.[PesNome] AS LocCliPesNome FROM ([LOCACAO] T1 WITH (NOLOCK) LEFT JOIN [PESSOA] T2 WITH (NOLOCK) ON T2.[PesCodigo] = T1.[LocCliPesCodigo]) ORDER BY T2.[PesNome] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR000O2,100,0,false,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("R000O3", "SELECT T1.[LocCliPesCodigo] AS LocCliPesCodigo, T1.[LocDatDevolucao], T2.[PesNome] AS LocCliPesNome, T1.[LocCodigo] FROM ([LOCACAO] T1 WITH (NOLOCK) LEFT JOIN [PESSOA] T2 WITH (NOLOCK) ON T2.[PesCodigo] = T1.[LocCliPesCodigo]) WHERE T2.[PesNome] = @AV12LocCli ORDER BY T1.[LocCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR000O3,100,0,false,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((int[]) buf[6])[0] = rslt.getInt(4) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
