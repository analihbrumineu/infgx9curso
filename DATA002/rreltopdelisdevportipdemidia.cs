/*
               File: RelTopDeLisDevPorTipDeMidia
        Description: Relatório de topo de lista sobre o total de devoluções por formato de mídia.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/12/2026 11:52:29.76
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
   public class rreltopdelisdevportipdemidia_wrapper : GXJWin
   {
      public rreltopdelisdevportipdemidia_wrapper( int hnd ,
                                                   ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class rreltopdelisdevportipdemidia : GXWinProcedure
   {
      public rreltopdelisdevportipdemidia( int hnd ,
                                           ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public rreltopdelisdevportipdemidia( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public rreltopdelisdevportipdemidia( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public rreltopdelisdevportipdemidia( IGxContext context ,
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
         rreltopdelisdevportipdemidia objrreltopdelisdevportipdemidia;
         objrreltopdelisdevportipdemidia = new rreltopdelisdevportipdemidia();
         objrreltopdelisdevportipdemidia.AV8DatInic = aP0_DatInicial;
         objrreltopdelisdevportipdemidia.AV9DatFina = aP1_DatFinal;
         objrreltopdelisdevportipdemidia.AV10Seleca = aP2_Selecao;
         objrreltopdelisdevportipdemidia.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrreltopdelisdevportipdemidia.executePrivateCatch ));
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
            getPrinter().GxSetDocName("Relatório de topo de lista sobre o total de devoluções por formato de mídia.") ;
            getPrinter().setModal(true) ;
            P_lines = (int)(gxYPage-(lineHeight*6)) ;
            Gx_line = (int)(P_lines+1) ;
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            AV13AuxLoc = 0 ;
            AV14Midias = new GxObjectCollection( context, "SDTMidTipRelatorio.SDTMidTipDevRelatorioItem", "AgoraVaiCurso", "SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem", "GeneXus.Programs") ;
            /* Using cursor R000R2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK0R3 = false ;
               A86LocCodi = R000R2_A86LocCodi[0] ;
               A89LocDatD = R000R2_A89LocDatD[0] ;
               n89LocDatD = R000R2_n89LocDatD[0] ;
               A106LocMid = R000R2_A106LocMid[0] ;
               n106LocMid = R000R2_n106LocMid[0] ;
               A102LocMid = R000R2_A102LocMid[0] ;
               A89LocDatD = R000R2_A89LocDatD[0] ;
               n89LocDatD = R000R2_n89LocDatD[0] ;
               if ( ( A89LocDatD >= AV8DatInic ) && ( A89LocDatD <= AV9DatFina ) && ( A89LocDatD != DateTimeUtil.CToD( "0", 2) ) )
               {
                  if ( ( A106LocMid != AV13AuxLoc ) )
                  {
                     if ( ( AV13AuxLoc != 0 ) )
                     {
                        AV14Midias.Add(AV15Item, 0);
                     }
                     AV15Item = new SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem(context) ;
                     AV15Item.gxTpr_Midtiprellocmidmidcodigo = A102LocMid ;
                     AV15Item.gxTpr_Midtiprellocmidmidtipo = A106LocMid ;
                     AV15Item.gxTpr_Midtipreltotal = 0 ;
                     AV13AuxLoc = A106LocMid ;
                  }
                  while ( (pr_default.getStatus(0) != 101) && ( R000R2_A106LocMid[0] == A106LocMid ) )
                  {
                     BRK0R3 = false ;
                     A86LocCodi = R000R2_A86LocCodi[0] ;
                     A89LocDatD = R000R2_A89LocDatD[0] ;
                     n89LocDatD = R000R2_n89LocDatD[0] ;
                     A89LocDatD = R000R2_A89LocDatD[0] ;
                     n89LocDatD = R000R2_n89LocDatD[0] ;
                     if ( ( A89LocDatD >= AV8DatInic ) && ( A89LocDatD <= AV9DatFina ) && ( A89LocDatD != DateTimeUtil.CToD( "0", 2) ) )
                     {
                        AV15Item.gxTpr_Midtipreltotal = (long)(AV15Item.gxTpr_Midtipreltotal+1) ;
                     }
                     BRK0R3 = true ;
                     pr_default.readNext(0);
                  }
               }
               if ( ! BRK0R3 )
               {
                  BRK0R3 = true ;
                  pr_default.readNext(0);
               }
            }
            pr_default.close(0);
            if ( ( AV13AuxLoc != 0 ) )
            {
               AV14Midias.Add(AV15Item, 0);
            }
            AV14Midias.Sort("[MidTipRelTotal]");
            AV16ContSe = 0 ;
            AV26GXV1 = 1 ;
            while ( ( AV26GXV1 <= AV14Midias.Count ) )
            {
               AV15Item = ((SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem)AV14Midias.Item(AV26GXV1)) ;
               if ( ( AV16ContSe < AV10Seleca ) )
               {
                  AV11LocMid = AV15Item.gxTpr_Midtiprellocmidmidtipo ;
                  if ( ( AV11LocMid == 1 ) )
                  {
                     AV17LocMid = "DVD" ;
                  }
                  else if ( ( AV11LocMid == 2 ) )
                  {
                     AV17LocMid = "Bluray" ;
                  }
                  else if ( ( AV11LocMid == 3 ) )
                  {
                     AV17LocMid = "VHS" ;
                  }
                  else if ( ( AV11LocMid == 4 ) )
                  {
                     AV17LocMid = "Box" ;
                  }
                  H0R0( false, 39) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV17LocMid, "@!")), 39, Gx_line+12, 144, Gx_line+27, 0) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+39) ;
                  AV12TotDev = AV15Item.gxTpr_Midtipreltotal ;
                  H0R0( false, 26) ;
                  getPrinter().GxDrawLine(52, Gx_line+0, 650, Gx_line+0, 1, 200, 200, 200, 0) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV12TotDev), "ZZZZZZZZZ9"), 581, Gx_line+7, 650, Gx_line+22, 2+256) ;
                  getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Total", 539, Gx_line+8, 568, Gx_line+21, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+26) ;
                  AV16ContSe = (long)(AV16ContSe+1) ;
               }
               AV26GXV1 = (int)(AV26GXV1+1) ;
            }
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H0R0( true, 0) ;
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

      protected void H0R0( bool bFoot ,
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
               getPrinter().GxDrawText(StringUtil.Format( AV8DatInic, "99/99/9999"), 65, Gx_line+91, 134, Gx_line+106, 0+256) ;
               getPrinter().GxDrawText(StringUtil.Format( AV9DatFina, "99/99/9999"), 169, Gx_line+91, 238, Gx_line+106, 0+256) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV10Seleca), "ZZZZZZZZZ9"), 91, Gx_line+117, 160, Gx_line+132, 2+256) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(Gx_page), "ZZZZZ9"), 606, Gx_line+26, 657, Gx_line+41, 2) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV21Pgmdes, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 81, Gx_line+52, 608, Gx_line+67, 0) ;
               getPrinter().GxDrawText(StringUtil.Format( Gx_date, "99/99/99"), 611, Gx_line+0, 666, Gx_line+15, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( Gx_time, "XXXXXXXX")), 611, Gx_line+13, 666, Gx_line+28, 0+256) ;
               getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("De", 39, Gx_line+91, 55, Gx_line+104, 0+256) ;
               getPrinter().GxDrawText("até", 143, Gx_line+91, 161, Gx_line+104, 0+256) ;
               getPrinter().GxDrawText("Seleção", 39, Gx_line+117, 85, Gx_line+130, 0+256) ;
               getPrinter().GxDrawText("Formato", 39, Gx_line+182, 84, Gx_line+195, 0+256) ;
               getPrinter().GxDrawText("Data:", 567, Gx_line+0, 598, Gx_line+13, 0+256) ;
               getPrinter().GxDrawText("Hora:", 567, Gx_line+13, 598, Gx_line+26, 0+256) ;
               getPrinter().GxDrawText("Página:", 554, Gx_line+26, 597, Gx_line+39, 0+256) ;
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
         GXAsk ask = new GXAsk( "Relatório de topo de lista sobre o total de devoluções por formato de mídia." , true , new GXAskObject[] {
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
         AV13AuxLoc = 0 ;
         AV14Midias = new GxObjectCollection( context, "SDTMidTipRelatorio.SDTMidTipDevRelatorioItem", "AgoraVaiCurso", "SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem", "GeneXus.Programs");
         scmdbuf = "" ;
         R000R2_A86LocCodi = new int[1] ;
         R000R2_A89LocDatD = new DateTime[] {DateTime.MinValue} ;
         R000R2_n89LocDatD = new bool[] {false} ;
         R000R2_A106LocMid = new short[1] ;
         R000R2_n106LocMid = new bool[] {false} ;
         R000R2_A102LocMid = new int[1] ;
         BRK0R3 = false ;
         A86LocCodi = 0 ;
         A89LocDatD = (DateTime)(DateTime.MinValue) ;
         n89LocDatD = false ;
         A106LocMid = 0 ;
         n106LocMid = false ;
         A102LocMid = 0 ;
         AV15Item = new SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem(context);
         AV16ContSe = 0 ;
         AV26GXV1 = 0 ;
         AV11LocMid = 0 ;
         AV17LocMid = "" ;
         Gx_OldLine = 0 ;
         AV12TotDev = 0 ;
         AV21Pgmdes = "" ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         Gx_time = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rreltopdelisdevportipdemidia__default(),
            new Object[][] {
                new Object[] {
               R000R2_A86LocCodi, R000R2_A89LocDatD, R000R2_n89LocDatD, R000R2_A106LocMid, R000R2_n106LocMid, R000R2_A102LocMid
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         Gx_time = DateTimeUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         AV21Pgmdes = "Relatório de topo de lista sobre o total de devoluções por formato de mídia." ;
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

      private short AV13AuxLoc ;
      private short A106LocMid ;
      private short AV11LocMid ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A86LocCodi ;
      private int A102LocMid ;
      private int AV26GXV1 ;
      private int Gx_OldLine ;
      private long AV10Seleca ;
      private long AV16ContSe ;
      private long AV12TotDev ;
      private String scmdbuf ;
      private String AV21Pgmdes ;
      private String Gx_time ;
      private DateTime AV8DatInic ;
      private DateTime AV9DatFina ;
      private DateTime A89LocDatD ;
      private DateTime Gx_date ;
      private bool askCanceled ;
      private bool BRK0R3 ;
      private bool n89LocDatD ;
      private bool n106LocMid ;
      private String AV17LocMid ;
      private IGxDataStore dsDefault ;
      private IDataReader R000R2 ;
      private IDataStoreProvider pr_default ;
      private int[] R000R2_A86LocCodi ;
      private DateTime[] R000R2_A89LocDatD ;
      private bool[] R000R2_n89LocDatD ;
      private short[] R000R2_A106LocMid ;
      private bool[] R000R2_n106LocMid ;
      private int[] R000R2_A102LocMid ;
      private GxObjectCollection AV14Midias ;
      private SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem AV15Item ;
   }

   public class rreltopdelisdevportipdemidia__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmR000R2 ;
          prmR000R2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("R000R2", "SELECT T1.[LocCodigo], T2.[LocDatDevolucao], T1.[LocMidMidTipo], T1.[LocMidMidCodigo] FROM ([LOCACAOLOCACAOMIDIA] T1 WITH (NOLOCK) INNER JOIN [LOCACAO] T2 WITH (NOLOCK) ON T2.[LocCodigo] = T1.[LocCodigo]) ORDER BY T1.[LocMidMidTipo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR000R2,100,0,true,false )
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
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
