/*
               File: Gx00C0
        Description: Lista de Seleção Cadastro de locações.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/3/2026 10:48:12.43
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
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class wgx00c0 : GXWorkpanel
   {
      public wgx00c0( int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wgx00c0( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wgx00c0( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "Gx00C0" ;
      }

      public override String getFrmTitle( )
      {
         return "Lista de Seleção Cadastro de locações." ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return ApplicationUI.getDefaultMenuBar(this) ;
      }

      public override int getFrmTop( )
      {
         return 0 ;
      }

      public override int getFrmLeft( )
      {
         return 0 ;
      }

      public override int getFrmWidth( )
      {
         return 550 ;
      }

      public override int getFrmHeight( )
      {
         return 402 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WGx00C0.htm";
      }

      public override int getFrmBackground( )
      {
         return UIFactory.getColor(15) ;
      }

      public override int getFrmForeground( )
      {
         return UIFactory.getColor(6) ;
      }

      public override bool isMainProgram( )
      {
         return IsMain;
      }

      public override bool isModal( )
      {
         return true ;
      }

      protected bool hasDBAccess( )
      {
         return true ;
      }

      public override int getRefreshTimeout( )
      {
         return 0 ;
      }

      public override bool getRefreshTimeoutAlways( )
      {
         return true ;
      }

      public override bool getPaintAfterStart( )
      {
         return true ;
      }

      public override int getBorderStyle( )
      {
         return 2 ;
      }

      public override bool getMaxButton( )
      {
         return true ;
      }

      public override bool getMinButton( )
      {
         return true ;
      }

      public override bool getCtrlBox( )
      {
         return true ;
      }

      public override bool getShowInTaskbar( )
      {
         return true ;
      }

      public override String getFormIcon( )
      {
         return "" ;
      }

      public override bool getAutocenter( )
      {
         return false ;
      }

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void execute( out int aP0_pLocCodigo )
      {
         this.AV12pLocCo = 0 ;
         executePrivate();
         aP0_pLocCodigo=this.AV12pLocCo;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load20( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwgx00c020 = new subwgx00c020 ();
         /* Using cursor W002I2 */
         pr_default.execute(0, new Object[] {AV5cLocCod, AV6cLocSit, AV7cLocDat, AV8cLocDat, AV9cLocDat, AV10cLocCl, AV11cLocVe});
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGrd_1.getSize() < 10000 ) ) )
         {
            A89LocDatD = W002I2_A89LocDatD[0] ;
            n89LocDatD = W002I2_n89LocDatD[0] ;
            A90LocDatC = W002I2_A90LocDatC[0] ;
            n90LocDatC = W002I2_n90LocDatC[0] ;
            A91LocCliP = W002I2_A91LocCliP[0] ;
            n91LocCliP = W002I2_n91LocCliP[0] ;
            A93LocVenP = W002I2_A93LocVenP[0] ;
            n93LocVenP = W002I2_n93LocVenP[0] ;
            A88LocDatL = W002I2_A88LocDatL[0] ;
            n88LocDatL = W002I2_n88LocDatL[0] ;
            A87LocSitu = W002I2_A87LocSitu[0] ;
            n87LocSitu = W002I2_n87LocSitu[0] ;
            A86LocCodi = W002I2_A86LocCodi[0] ;
            /* Execute user event: E11V2I2 */
            E11V2I2 ();
            pr_default.readNext(0);
         }
         if ( subGrd_1.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class Gx00C0_load20 : GXLoadProducer
      {
         wgx00c0 _sf ;

         public Gx00C0_load20( wgx00c0 uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer20();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load20();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors20();
         }

      }

      public override void GXRefresh( )
      {
         ControlsToVariables();
         GXRefreshCommand();
      }

      protected void GXRefreshCommand( )
      {
         if ( ! gxIsRefreshing )
         {
            gxIsRefreshing = true ;
            ControlsToVariables();
            standAlone();
            VariablesToControls();
            subGrd_1.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow20( )
      {
         return true;
      }

      public void autoRefresh_flow20( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( (AV5cLocCod!=cV5cLocCod)||(AV6cLocSit!=cV6cLocSit)||(AV7cLocDat!=cV7cLocDat)||(AV8cLocDat!=cV8cLocDat)||(AV9cLocDat!=cV9cLocDat)||(AV10cLocCl!=cV10cLocCl)||(AV11cLocVe!=cV11cLocVe) ) || (!loadedFirstTime && ! isLoadAtStartup_flow20() )) {
            subfile.refresh();
            resetSubfileConditions_flow20() ;
         }
      }

      public bool getSearch_flow20( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow20( )
      {
         cV5cLocCod = AV5cLocCod ;
         cV6cLocSit = AV6cLocSit ;
         cV7cLocDat = AV7cLocDat ;
         cV8cLocDat = AV8cLocDat ;
         cV9cLocDat = AV9cLocDat ;
         cV10cLocCl = AV10cLocCl ;
         cV11cLocVe = AV11cLocVe ;
      }

      public void resetSearchConditions_flow20( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow20( )
      {
         return new subwgx00c020 ();
      }

      public bool getSearch_flow20( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow20( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow20( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow20( )
      {
         GXRefreshCommand20 ();
      }

      public class Gx00C0_flow20 : GXSubfileFlow
      {
         wgx00c0 _sf ;

         public Gx00C0_flow20( wgx00c0 uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow20();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow20(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow20();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow20();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow20(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow20();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow20(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow20(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow20(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow20();
         }

      }

      protected void GXRefreshCommand20( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public override void GXEnter( )
      {
         /* Execute user event: E12V2I2 */
         E12V2I2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V2I2( )
      {
         eventLevelContext();
         /* Enter Routine */
         AV12pLocCo = A86LocCodi ;
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
         eventLevelResetContext();
      }

      public void loadToBuffer20( )
      {
         subwgx00c020 oAux = subwgx00c020 ;
         subwgx00c020 = new subwgx00c020 ();
         variablesToSubfile20 ();
         subGrd_1.addElement(subwgx00c020);
         subwgx00c020 = oAux;
      }

      private void E11V2I2( )
      {
         /* Load Routine */
         subGrd_1.loadCommand();
      }

      protected void closeCursors20( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 0 , 0 , 550 , 402 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavCloccodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),203, 24, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 203 , 24 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5cLocCod" );
         ((GXEdit) edtavCloccodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCloccodigo.addFocusListener(this);
         edtavCloccodigo.getGXComponent().setHelpId("HLP_WGx00C0.htm");
         cmbavClocsituacao = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 203 , 48 , 89 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6cLocSit" );
         ((GXComboBox) cmbavClocsituacao.getGXComponent()).addItem( new java.lang.Short(1),"Digitada");
         ((GXComboBox) cmbavClocsituacao.getGXComponent()).addItem( new java.lang.Short(2),"Realizada");
         ((GXComboBox) cmbavClocsituacao.getGXComponent()).addItem( new java.lang.Short(3),"Devolvida");
         ((GXComboBox) cmbavClocsituacao.getGXComponent()).addItem( new java.lang.Short(4),"Cancelada");
         cmbavClocsituacao.addFocusListener(this);
         cmbavClocsituacao.addItemListener(this);
         cmbavClocsituacao.getGXComponent().setHelpId("HLP_WGx00C0.htm");
         edtavClocdatlocacao = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),203, 72, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 203 , 72 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7cLocDat" );
         ((GXEdit) edtavClocdatlocacao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavClocdatlocacao.addFocusListener(this);
         edtavClocdatlocacao.getGXComponent().setHelpId("HLP_WGx00C0.htm");
         edtavClocdatdevolucao = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),203, 96, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 203 , 96 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8cLocDat" );
         ((GXEdit) edtavClocdatdevolucao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavClocdatdevolucao.addFocusListener(this);
         edtavClocdatdevolucao.getGXComponent().setHelpId("HLP_WGx00C0.htm");
         edtavClocdatcancelamento = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),203, 120, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 203 , 120 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9cLocDat" );
         ((GXEdit) edtavClocdatcancelamento.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavClocdatcancelamento.addFocusListener(this);
         edtavClocdatcancelamento.getGXComponent().setHelpId("HLP_WGx00C0.htm");
         edtavClocclipescodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),203, 144, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 203 , 144 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV10cLocCl" );
         ((GXEdit) edtavClocclipescodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavClocclipescodigo.addFocusListener(this);
         edtavClocclipescodigo.getGXComponent().setHelpId("HLP_WGx00C0.htm");
         edtavClocvenpescodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),203, 168, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 203 , 168 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV11cLocVe" );
         ((GXEdit) edtavClocvenpescodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavClocvenpescodigo.addFocusListener(this);
         edtavClocvenpescodigo.getGXComponent().setHelpId("HLP_WGx00C0.htm");
         addSubfile ( subGrd_1  = new GXSubfile ( new Gx00C0_load20(this), new Gx00C0_flow20(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 116, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 115 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A86LocCodi" ), "Código da locação"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 115 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 126 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A87LocSitu" ), "Situação da locação"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 126 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),0, 0, 104, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.DATE, false, false, 0, false) , null ,  0 , 0 , 103 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A88LocDatL" ), "Data da locação"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 103 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 9 , 18 , GXPanel1 , 21 , 192 , 403 , 193 ,  18 ));
         ((GXComboBox) subGrd_1.getColumn(1).getGXComponent()).addItem( new java.lang.Short(1),"Digitada");
         ((GXComboBox) subGrd_1.getColumn(1).getGXComponent()).addItem( new java.lang.Short(2),"Realizada");
         ((GXComboBox) subGrd_1.getColumn(1).getGXComponent()).addItem( new java.lang.Short(3),"Devolvida");
         ((GXComboBox) subGrd_1.getColumn(1).getGXComponent()).addItem( new java.lang.Short(4),"Cancelada");
         subGrd_1.addActionListener(this);
         subGrd_1.addFocusListener(this);
         subGrd_1.setSortOnClick(true);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Confirmar" ,  442 ,  24 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Confirmar");
         bttBtn_enter.addActionListener(this);
         bttBtn_cancel = UIFactory.getGXButton( GXPanel1 , "Fechar" ,  442 ,  52 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_cancel.setTooltip("Fechar");
         bttBtn_cancel.addActionListener(this);
         bttBtn_cancel.setFiresEvents(false);
         bttBtn_refresh = UIFactory.getGXButton( GXPanel1 , "Renovar" ,  442 ,  80 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_refresh.setTooltip("Renovar");
         bttBtn_refresh.addActionListener(this);
         bttBtn_refresh.setFiresEvents(false);
         bttBtn_help = UIFactory.getGXButton( GXPanel1 , "Ajuda" ,  442 ,  118 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_help.setTooltip("Ajuda");
         bttBtn_help.addActionListener(this);
         bttBtn_help.setFiresEvents(false);
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Código da locação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 24 , 107 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Situação da locação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 48 , 118 , 13 );
         lbllbl11 = UIFactory.getLabel(GXPanel1, "Data da locação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 72 , 95 , 13 );
         lbllbl13 = UIFactory.getLabel(GXPanel1, "Data da devolução", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 96 , 109 , 13 );
         lbllbl15 = UIFactory.getLabel(GXPanel1, "Data de cancelamento", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 120 , 129 , 13 );
         lbllbl17 = UIFactory.getLabel(GXPanel1, "Código do cliente locatário", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 144 , 153 , 13 );
         lbllbl19 = UIFactory.getLabel(GXPanel1, "Código do vendedor locador", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 168 , 161 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavCloccodigo ,
                   cmbavClocsituacao ,
                   edtavClocdatlocacao ,
                   edtavClocdatdevolucao ,
                   edtavClocdatcancelamento ,
                   edtavClocclipescodigo ,
                   edtavClocvenpescodigo ,
                   subGrd_1 ,
                   bttBtn_enter ,
                   bttBtn_cancel ,
                   bttBtn_refresh ,
                   bttBtn_help
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGrd_1, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile20( )
      {
         subwgx00c020.setLocCodigo(A86LocCodi);
         subwgx00c020.setLocSituacao(A87LocSitu);
         subwgx00c020.setLocDatLocacao(A88LocDatL);
      }

      protected void subfileToVariables20( )
      {
         A86LocCodi = subwgx00c020.getLocCodigo();
         A87LocSitu = subwgx00c020.getLocSituacao();
         A88LocDatL = subwgx00c020.getLocDatLocacao();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavCloccodigo.setValue( AV5cLocCod );
         cmbavClocsituacao.setValue( AV6cLocSit );
         edtavClocdatlocacao.setValue( AV7cLocDat );
         edtavClocdatdevolucao.setValue( AV8cLocDat );
         edtavClocdatcancelamento.setValue( AV9cLocDat );
         edtavClocclipescodigo.setValue( AV10cLocCl );
         edtavClocvenpescodigo.setValue( AV11cLocVe );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5cLocCod = (int)(edtavCloccodigo.getValue()) ;
         edtavCloccodigo.setValue(AV5cLocCod);
         AV6cLocSit = (short)(cmbavClocsituacao.getValue()) ;
         cmbavClocsituacao.setValue(AV6cLocSit);
         AV7cLocDat = (DateTime)(edtavClocdatlocacao.getValue()) ;
         edtavClocdatlocacao.setValue(AV7cLocDat);
         AV8cLocDat = (DateTime)(edtavClocdatdevolucao.getValue()) ;
         edtavClocdatdevolucao.setValue(AV8cLocDat);
         AV9cLocDat = (DateTime)(edtavClocdatcancelamento.getValue()) ;
         edtavClocdatcancelamento.setValue(AV9cLocDat);
         AV10cLocCl = (int)(edtavClocclipescodigo.getValue()) ;
         edtavClocclipescodigo.setValue(AV10cLocCl);
         AV11cLocVe = (int)(edtavClocvenpescodigo.getValue()) ;
         edtavClocvenpescodigo.setValue(AV11cLocVe);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGrd_1.inValidElement() )
         {
            subwgx00c020 = ( subwgx00c020 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx00c020 = new subwgx00c020 ();
         }
         subfileToVariables20 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile20 ();
         subGrd_1.refreshLineValue(subwgx00c020);
      }

      protected void reloadGridRow( )
      {
         if ( subGrd_1.inValidElement() )
         {
            subwgx00c020 = ( subwgx00c020 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx00c020 = new subwgx00c020 ();
         }
         subfileToVariables20 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttBtn_cancel.isEventSource(eventSource) ) {
            if (canCleanup())
               this.cleanup();

            return;
         }
         if ( bttBtn_refresh.isEventSource(eventSource) ) {
            GXRefresh();
            return;
         }
         if ( bttBtn_help.isEventSource(eventSource) ) {
            showHelp();
            return;
         }
         if ( bttBtn_enter.isEventSource(eventSource) ) {
            /* Execute user event: E12V2I2 */
            E12V2I2 ();
            return;
         }
         if ( subGrd_1.isEventSource(eventSource) ) {
            /* Execute user event: E12V2I2 */
            E12V2I2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavCloccodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCloccodigo.getGXCursor() );
            return;
         }
         if ( cmbavClocsituacao.isEventSource(eventSource) ) {
            setGXCursor( cmbavClocsituacao.getGXCursor() );
            return;
         }
         if ( edtavClocdatlocacao.isEventSource(eventSource) ) {
            setGXCursor( edtavClocdatlocacao.getGXCursor() );
            return;
         }
         if ( edtavClocdatdevolucao.isEventSource(eventSource) ) {
            setGXCursor( edtavClocdatdevolucao.getGXCursor() );
            return;
         }
         if ( edtavClocdatcancelamento.isEventSource(eventSource) ) {
            setGXCursor( edtavClocdatcancelamento.getGXCursor() );
            return;
         }
         if ( edtavClocclipescodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavClocclipescodigo.getGXCursor() );
            return;
         }
         if ( edtavClocvenpescodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavClocvenpescodigo.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtavCloccodigo.isEventSource(eventSource) ) {
            AV5cLocCod = edtavCloccodigo.getValue() ;
            return;
         }
         if ( cmbavClocsituacao.isEventSource(eventSource) ) {
            AV6cLocSit = cmbavClocsituacao.getValue() ;
            return;
         }
         if ( edtavClocdatlocacao.isEventSource(eventSource) ) {
            AV7cLocDat = edtavClocdatlocacao.getValue() ;
            return;
         }
         if ( edtavClocdatdevolucao.isEventSource(eventSource) ) {
            AV8cLocDat = edtavClocdatdevolucao.getValue() ;
            return;
         }
         if ( edtavClocdatcancelamento.isEventSource(eventSource) ) {
            AV9cLocDat = edtavClocdatcancelamento.getValue() ;
            return;
         }
         if ( edtavClocclipescodigo.isEventSource(eventSource) ) {
            AV10cLocCl = edtavClocclipescodigo.getValue() ;
            return;
         }
         if ( edtavClocvenpescodigo.isEventSource(eventSource) ) {
            AV11cLocVe = edtavClocvenpescodigo.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (triggerEventEnter(eventSource, keyCode)) {
            /* Execute user event: E12V2I2 */
            E12V2I2 ();
            return true ;
         }
         return false;
      }

      public override bool contextItemDispatch( Object eventSource ,
                                                String action )
      {
         return false;
      }

      public override bool menuActionPerformed( String action )
      {
         return false;
      }

      public override IGXButton getCancelButton( )
      {
         return bttBtn_cancel ;
      }

      public void refreshArray( String array )
      {
      }

      public void refreshSDT( String name )
      {
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
         }
         this.AV12pLocCo = AV12pLocCo;
         stopThreads();
         CloseOpenCursors();
         base.cleanup();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         com.genexus.Application.cleanup( base.context , this, remoteHandle);
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         subwgx00c020 = new subwgx00c020();
         scmdbuf = "" ;
         AV5cLocCod = 0 ;
         AV6cLocSit = 0 ;
         AV7cLocDat = (DateTime)(DateTime.MinValue) ;
         AV8cLocDat = (DateTime)(DateTime.MinValue) ;
         AV9cLocDat = (DateTime)(DateTime.MinValue) ;
         AV10cLocCl = 0 ;
         AV11cLocVe = 0 ;
         W002I2_A89LocDatD = new DateTime[] {DateTime.MinValue} ;
         W002I2_n89LocDatD = new bool[] {false} ;
         W002I2_A90LocDatC = new DateTime[] {DateTime.MinValue} ;
         W002I2_n90LocDatC = new bool[] {false} ;
         W002I2_A91LocCliP = new int[1] ;
         W002I2_n91LocCliP = new bool[] {false} ;
         W002I2_A93LocVenP = new int[1] ;
         W002I2_n93LocVenP = new bool[] {false} ;
         W002I2_A88LocDatL = new DateTime[] {DateTime.MinValue} ;
         W002I2_n88LocDatL = new bool[] {false} ;
         W002I2_A87LocSitu = new short[1] ;
         W002I2_n87LocSitu = new bool[] {false} ;
         W002I2_A86LocCodi = new int[1] ;
         A89LocDatD = (DateTime)(DateTime.MinValue) ;
         n89LocDatD = false ;
         A90LocDatC = (DateTime)(DateTime.MinValue) ;
         n90LocDatC = false ;
         A91LocCliP = 0 ;
         n91LocCliP = false ;
         A93LocVenP = 0 ;
         n93LocVenP = false ;
         A88LocDatL = (DateTime)(DateTime.MinValue) ;
         n88LocDatL = false ;
         A87LocSitu = 0 ;
         n87LocSitu = false ;
         A86LocCodi = 0 ;
         gxIsRefreshing = false ;
         cV5cLocCod = 0 ;
         cV6cLocSit = 0 ;
         cV7cLocDat = (DateTime)(DateTime.MinValue) ;
         cV8cLocDat = (DateTime)(DateTime.MinValue) ;
         cV9cLocDat = (DateTime)(DateTime.MinValue) ;
         cV10cLocCl = 0 ;
         cV11cLocVe = 0 ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wgx00c0__default(),
            new Object[][] {
                new Object[] {
               W002I2_A89LocDatD, W002I2_n89LocDatD, W002I2_A90LocDatC, W002I2_n90LocDatC, W002I2_A91LocCliP, W002I2_n91LocCliP, W002I2_A93LocVenP, W002I2_n93LocVenP, W002I2_A88LocDatL, W002I2_n88LocDatL,
               W002I2_A87LocSitu, W002I2_n87LocSitu, W002I2_A86LocCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV6cLocSit ;
      protected short A87LocSitu ;
      protected short cV6cLocSit ;
      protected int AV5cLocCod ;
      protected int AV10cLocCl ;
      protected int AV11cLocVe ;
      protected int A91LocCliP ;
      protected int A93LocVenP ;
      protected int A86LocCodi ;
      protected int cV5cLocCod ;
      protected int cV10cLocCl ;
      protected int cV11cLocVe ;
      protected int AV12pLocCo ;
      protected String scmdbuf ;
      protected DateTime AV7cLocDat ;
      protected DateTime AV8cLocDat ;
      protected DateTime AV9cLocDat ;
      protected DateTime A89LocDatD ;
      protected DateTime A90LocDatC ;
      protected DateTime A88LocDatL ;
      protected DateTime cV7cLocDat ;
      protected DateTime cV8cLocDat ;
      protected DateTime cV9cLocDat ;
      protected bool n89LocDatD ;
      protected bool n90LocDatC ;
      protected bool n91LocCliP ;
      protected bool n93LocVenP ;
      protected bool n88LocDatL ;
      protected bool n87LocSitu ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwgx00c020 subwgx00c020 ;
      protected IDataReader W002I2 ;
      protected IDataStoreProvider pr_default ;
      protected DateTime[] W002I2_A89LocDatD ;
      protected bool[] W002I2_n89LocDatD ;
      protected DateTime[] W002I2_A90LocDatC ;
      protected bool[] W002I2_n90LocDatC ;
      protected int[] W002I2_A91LocCliP ;
      protected bool[] W002I2_n91LocCliP ;
      protected int[] W002I2_A93LocVenP ;
      protected bool[] W002I2_n93LocVenP ;
      protected DateTime[] W002I2_A88LocDatL ;
      protected bool[] W002I2_n88LocDatL ;
      protected short[] W002I2_A87LocSitu ;
      protected bool[] W002I2_n87LocSitu ;
      protected int[] W002I2_A86LocCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavCloccodigo ;
      protected GUIObjectShort cmbavClocsituacao ;
      protected GUIObjectDatetime edtavClocdatlocacao ;
      protected GUIObjectDatetime edtavClocdatdevolucao ;
      protected GUIObjectDatetime edtavClocdatcancelamento ;
      protected GUIObjectInt edtavClocclipescodigo ;
      protected GUIObjectInt edtavClocvenpescodigo ;
      protected GXSubfile subGrd_1 ;
      protected IGXButton bttBtn_enter ;
      protected IGXButton bttBtn_cancel ;
      protected IGXButton bttBtn_refresh ;
      protected IGXButton bttBtn_help ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl11 ;
      protected ILabel lbllbl13 ;
      protected ILabel lbllbl15 ;
      protected ILabel lbllbl17 ;
      protected ILabel lbllbl19 ;
      protected int aP0_pLocCodigo ;
   }

   public class wgx00c0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmW002I2 ;
          prmW002I2 = new Object[] {
          new Object[] {"@AV5cLocCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cLocSit",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV7cLocDat",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8cLocDat",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV9cLocDat",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV10cLocCl",SqlDbType.Int,9,0} ,
          new Object[] {"@AV11cLocVe",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W002I2", "SELECT [LocDatDevolucao], [LocDatCancelamento], [LocCliPesCodigo], [LocVenPesCodigo], [LocDatLocacao], [LocSituacao], [LocCodigo] FROM [LOCACAO] WITH (NOLOCK) WHERE ([LocCodigo] >= @AV5cLocCod) AND ([LocSituacao] >= @AV6cLocSit) AND ([LocDatLocacao] >= @AV7cLocDat) AND ([LocDatDevolucao] >= @AV8cLocDat) AND ([LocDatCancelamento] >= @AV9cLocDat) AND ([LocCliPesCodigo] >= @AV10cLocCl) AND ([LocVenPesCodigo] >= @AV11cLocVe) ORDER BY [LocCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002I2,9,0,true,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((int[]) buf[4])[0] = rslt.getInt(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((int[]) buf[6])[0] = rslt.getInt(4) ;
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
             case 0 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                break;
       }
    }

 }

}
