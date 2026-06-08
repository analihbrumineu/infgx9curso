/*
               File: RelFilCategoria
        Description: Relatório de filmes por categoria.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 4/27/2026 11:15:51.20
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
   public class rrelfilcategoria_wrapper : GXJWin
   {
      public rrelfilcategoria_wrapper( int hnd ,
                                       ModelContext jContext ) : base(hnd, jContext)
      {
      }

   }

   public class rrelfilcategoria : GXWinProcedure
   {
      public rrelfilcategoria( int hnd ,
                               ModelContext jContext ) : base(hnd, jContext)
      {
         IsMain = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
      }

      public rrelfilcategoria( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public rrelfilcategoria( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public rrelfilcategoria( IGxContext context ,
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
         rrelfilcategoria objrrelfilcategoria;
         objrrelfilcategoria = new rrelfilcategoria();
         objrrelfilcategoria.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrrelfilcategoria.executePrivateCatch ));
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
            getPrinter().GxSetDocName("Relatório de filmes por categoria.") ;
            getPrinter().setModal(true) ;
            P_lines = (int)(gxYPage-(lineHeight*6)) ;
            Gx_line = (int)(P_lines+1) ;
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            /* Using cursor R00092 */
            pr_default.execute(0, new Object[] {AV14FilCod, AV15FilCod, AV16CatCod, AV17CatCod});
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK093 = false ;
               A32CatCodi = R00092_A32CatCodi[0] ;
               n32CatCodi = R00092_n32CatCodi[0] ;
               A33CatNome = R00092_A33CatNome[0] ;
               A28FilCodi = R00092_A28FilCodi[0] ;
               A55FilOsca = R00092_A55FilOsca[0] ;
               n55FilOsca = R00092_n55FilOsca[0] ;
               A29FilNome = R00092_A29FilNome[0] ;
               n29FilNome = R00092_n29FilNome[0] ;
               A33CatNome = R00092_A33CatNome[0] ;
               H090( false, 39) ;
               getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV10CatNom, "@!")), 26, Gx_line+13, 375, Gx_line+28, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+39) ;
               AV13TotFil = 0 ;
               while ( (pr_default.getStatus(0) != 101) && ( String.CompareOrdinal(R00092_A33CatNome[0].TrimEnd(' '), A33CatNome.TrimEnd(' ') ) == 0 ) && ( R00092_A32CatCodi[0] == A32CatCodi ) )
               {
                  BRK093 = false ;
                  A28FilCodi = R00092_A28FilCodi[0] ;
                  A55FilOsca = R00092_A55FilOsca[0] ;
                  n55FilOsca = R00092_n55FilOsca[0] ;
                  A29FilNome = R00092_A29FilNome[0] ;
                  n29FilNome = R00092_n29FilNome[0] ;
                  jContext.msgStatus("Lendo filmes...");
                  AV18FilGan = "" ;
                  if ( ( A55FilOsca == 1 ) )
                  {
                     AV18FilGan = "*" ;
                  }
                  H090( false, 39) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV11FilNom, "@!")), 117, Gx_line+13, 466, Gx_line+28, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV18FilGan, "X")), 533, Gx_line+13, 571, Gx_line+28, 0) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+39) ;
                  AV13TotFil = (long)(AV13TotFil+1) ;
                  BRK093 = true ;
                  pr_default.readNext(0);
               }
               if ( ! BRK093 )
               {
                  BRK093 = true ;
                  pr_default.readNext(0);
               }
            }
            pr_default.close(0);
            jContext.msgStatus("");
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H090( true, 0) ;
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

      protected void H090( bool bFoot ,
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
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+16) ;
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
               getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( AV21Pgmdes, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 234, Gx_line+104, 443, Gx_line+119, 0+256) ;
               getPrinter().GxDrawText(StringUtil.Format( Gx_date, "99/99/99"), 585, Gx_line+26, 636, Gx_line+41, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( StringUtil.Format( Gx_time, "XXXXXXXX")), 585, Gx_line+39, 636, Gx_line+54, 0) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(Gx_page), "ZZZZZ9"), 585, Gx_line+52, 636, Gx_line+67, 2) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV16CatCod), "ZZZZZZZZ9"), 299, Gx_line+156, 361, Gx_line+171, 2+256) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV17CatCod), "ZZZZZZZZ9"), 390, Gx_line+156, 452, Gx_line+171, 2+256) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV14FilCod), "ZZZZZZZZ9"), 299, Gx_line+182, 361, Gx_line+197, 2+256) ;
               getPrinter().GxDrawText(StringUtil.Format( (decimal)(AV15FilCod), "ZZZZZZZZ9"), 390, Gx_line+182, 452, Gx_line+197, 2+256) ;
               getPrinter().GxAttris("MS Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Categorias:", 221, Gx_line+156, 285, Gx_line+169, 0+256) ;
               getPrinter().GxDrawText("até", 364, Gx_line+156, 382, Gx_line+169, 0+256) ;
               getPrinter().GxDrawText("Filmes:", 221, Gx_line+182, 260, Gx_line+195, 0+256) ;
               getPrinter().GxDrawText("até", 364, Gx_line+182, 382, Gx_line+195, 0+256) ;
               getPrinter().GxDrawText("Data:", 533, Gx_line+26, 564, Gx_line+39, 0+256) ;
               getPrinter().GxDrawText("Hora:", 533, Gx_line+39, 564, Gx_line+52, 0+256) ;
               getPrinter().GxDrawText("Página:", 533, Gx_line+52, 576, Gx_line+65, 0+256) ;
               getPrinter().GxDrawText("Categoria", 39, Gx_line+208, 93, Gx_line+221, 0+256) ;
               getPrinter().GxDrawText("Filme", 117, Gx_line+221, 146, Gx_line+234, 0+256) ;
               getPrinter().GxDrawText("Oscar", 533, Gx_line+221, 566, Gx_line+234, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+247) ;
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
         GXAsk ask = new GXAsk( "Relatório de filmes por categoria." , true , new GXAskObject[] {
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
         scmdbuf = "" ;
         AV14FilCod = 0 ;
         AV15FilCod = 0 ;
         AV16CatCod = 0 ;
         AV17CatCod = 0 ;
         R00092_A32CatCodi = new int[1] ;
         R00092_n32CatCodi = new bool[] {false} ;
         R00092_A33CatNome = new String[] {""} ;
         R00092_A28FilCodi = new int[1] ;
         R00092_A55FilOsca = new short[1] ;
         R00092_n55FilOsca = new bool[] {false} ;
         R00092_A29FilNome = new String[] {""} ;
         R00092_n29FilNome = new bool[] {false} ;
         BRK093 = false ;
         A32CatCodi = 0 ;
         n32CatCodi = false ;
         A33CatNome = "" ;
         A28FilCodi = 0 ;
         A55FilOsca = 0 ;
         n55FilOsca = false ;
         A29FilNome = "" ;
         n29FilNome = false ;
         AV10CatNom = "" ;
         Gx_OldLine = 0 ;
         AV13TotFil = 0 ;
         AV18FilGan = "" ;
         AV11FilNom = "" ;
         AV21Pgmdes = "" ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         Gx_time = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rrelfilcategoria__default(),
            new Object[][] {
                new Object[] {
               R00092_A32CatCodi, R00092_n32CatCodi, R00092_A33CatNome, R00092_A28FilCodi, R00092_A55FilOsca, R00092_n55FilOsca, R00092_A29FilNome, R00092_n29FilNome
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         Gx_time = DateTimeUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         AV21Pgmdes = "Relatório de filmes por categoria." ;
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

      private short A55FilOsca ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int AV14FilCod ;
      private int AV15FilCod ;
      private int AV16CatCod ;
      private int AV17CatCod ;
      private int A32CatCodi ;
      private int A28FilCodi ;
      private int Gx_OldLine ;
      private long AV13TotFil ;
      private String scmdbuf ;
      private String AV18FilGan ;
      private String AV21Pgmdes ;
      private String Gx_time ;
      private DateTime Gx_date ;
      private bool askCanceled ;
      private bool BRK093 ;
      private bool n32CatCodi ;
      private bool n55FilOsca ;
      private bool n29FilNome ;
      private String A33CatNome ;
      private String A29FilNome ;
      private String AV10CatNom ;
      private String AV11FilNom ;
      private IGxDataStore dsDefault ;
      private IDataReader R00092 ;
      private IDataStoreProvider pr_default ;
      private int[] R00092_A32CatCodi ;
      private bool[] R00092_n32CatCodi ;
      private String[] R00092_A33CatNome ;
      private int[] R00092_A28FilCodi ;
      private short[] R00092_A55FilOsca ;
      private bool[] R00092_n55FilOsca ;
      private String[] R00092_A29FilNome ;
      private bool[] R00092_n29FilNome ;
   }

   public class rrelfilcategoria__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmR00092 ;
          prmR00092 = new Object[] {
          new Object[] {"@AV14FilCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV15FilCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV16CatCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV17CatCod",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("R00092", "SELECT T1.[CatCodigo], T2.[CatNome], T1.[FilCodigo], T1.[FilOscar], T1.[FilNome] FROM ([FILME] T1 WITH (NOLOCK) LEFT JOIN [CATEGORIA] T2 WITH (NOLOCK) ON T2.[CatCodigo] = T1.[CatCodigo]) WHERE (T1.[FilCodigo] >= @AV14FilCod and T1.[FilCodigo] <= @AV15FilCod) AND (T1.[CatCodigo] >= @AV16CatCod and T1.[CatCodigo] <= @AV17CatCod) ORDER BY T2.[CatNome], T1.[CatCodigo], T1.[FilNome] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmR00092,100,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
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
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
