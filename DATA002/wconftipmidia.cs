/*
               File: ConfTipMidia
        Description: Configurações tipo de mídia.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/8/2026 11:43:20.29
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
   public class wconftipmidia : GXWorkpanel
   {
      public wconftipmidia( int hnd ,
                            ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wconftipmidia( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wconftipmidia( IGxContext context ,
                            int hnd ,
                            ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "ConfTipMidia" ;
      }

      public override String getFrmTitle( )
      {
         return "Configurações tipo de mídia." ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return null;
      }

      public override bool useCallersMenuBar( )
      {
         return true;
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
         return 871 ;
      }

      public override int getFrmHeight( )
      {
         return 468 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WConfTipMidia.htm";
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
         return false;
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

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load02( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwconftipmidia02 = new subwconftipmidia02 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV8MidTipo ,
                                              AV10CatNom ,
                                              A35MidTipo ,
                                              A33CatNome },
                                              new int[] {
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W001U2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf2.getSize() < 10000 ) ) )
         {
            A85ConfTip = W001U2_A85ConfTip[0] ;
            n85ConfTip = W001U2_n85ConfTip[0] ;
            A35MidTipo = W001U2_A35MidTipo[0] ;
            A33CatNome = W001U2_A33CatNome[0] ;
            n33CatNome = W001U2_n33CatNome[0] ;
            A32CatCodi = W001U2_A32CatCodi[0] ;
            A33CatNome = W001U2_A33CatNome[0] ;
            n33CatNome = W001U2_n33CatNome[0] ;
            /* Execute user event: E11V1U2 */
            E11V1U2 ();
            pr_default.readNext(0);
         }
         if ( subGxsf2.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class ConfTipMidia_load02 : GXLoadProducer
      {
         wconftipmidia _sf ;

         public ConfTipMidia_load02( wconftipmidia uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer02();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load02();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors02();
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
            subGxsf2.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow02( )
      {
         return true;
      }

      public void autoRefresh_flow02( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow02() )) {
            subfile.refresh();
            resetSubfileConditions_flow02() ;
         }
      }

      public bool getSearch_flow02( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow02( )
      {
      }

      public void resetSearchConditions_flow02( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow02( )
      {
         return new subwconftipmidia02 ();
      }

      public bool getSearch_flow02( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow02( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow02( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow02( )
      {
         GXRefreshCommand02 ();
      }

      public class ConfTipMidia_flow02 : GXSubfileFlow
      {
         wconftipmidia _sf ;

         public ConfTipMidia_flow02( wconftipmidia uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow02();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow02(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow02();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow02();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow02(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow02();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow02(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow02(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow02(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow02();
         }

      }

      protected void GXRefreshCommand02( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public void loadToBuffer02( )
      {
         subwconftipmidia02 oAux = subwconftipmidia02 ;
         subwconftipmidia02 = new subwconftipmidia02 ();
         variablesToSubfile02 ();
         subGxsf2.addElement(subwconftipmidia02);
         subwconftipmidia02 = oAux;
      }

      private void E11V1U2( )
      {
         AV6ConfTip = (decimal)(0M) ;
         AV5Marcado = "" ;
         /* Load Routine */
         AV7ConfTip = A85ConfTip ;
         subGxsf2.loadCommand();
      }

      protected void closeCursors02( )
      {
         pr_default.close(0);
      }

      protected void E12V1U2( )
      {
         eventLevelContext();
         /* 'Marcado' Routine */
         for (java.util.Enumeration en0 = subGxsf2.elements(); en0.hasMoreElements();)
         {
            subwconftipmidia02 = (subwconftipmidia02) en0.nextElement();
            subfileToVariables02 ();
            AV5Marcado = "S" ;
            variablesToSubfile02 ();
            subGxsf2.refreshLineValueFEL(subwconftipmidia02);
         }
         eventLevelContext( );
      }

      protected void E13V1U2( )
      {
         eventLevelContext();
         /* 'Desmarcado' Routine */
         for (java.util.Enumeration en1 = subGxsf2.elements(); en1.hasMoreElements();)
         {
            subwconftipmidia02 = (subwconftipmidia02) en1.nextElement();
            subfileToVariables02 ();
            AV5Marcado = "N" ;
            variablesToSubfile02 ();
            subGxsf2.refreshLineValueFEL(subwconftipmidia02);
         }
         eventLevelContext( );
      }

      protected void E14V1U2( )
      {
         eventLevelContext();
         /* 'Novo' Routine */
         new tconftipmidia(context, base.remoteHandle, base.context).execute(  "INS") ;
         GXRefresh();
      }

      protected void E15V1U2( )
      {
         eventLevelContext();
         /* 'Gravar' Routine */
         for (java.util.Enumeration en2 = subGxsf2.elements(); en2.hasMoreElements();)
         {
            subwconftipmidia02 = (subwconftipmidia02) en2.nextElement();
            subfileToVariables02 ();
            if ( ( String.CompareOrdinal(AV5Marcado.TrimEnd(' '), "S".TrimEnd(' ') ) == 0 ) && ( AV7ConfTip != AV6ConfTip ) && ( AV6ConfTip > Convert.ToDecimal( 0 )) )
            {
               new pgraconftipmidia(context, base.remoteHandle, base.context).execute(  A35MidTipo,  A32CatCodi,  AV6ConfTip) ;
            }
            variablesToSubfile02 ();
            subGxsf2.refreshLineValueFEL(subwconftipmidia02);
         }
         eventLevelContext( );
         GXRefresh();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 871 , 468 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         cmbavMidtipo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 156 , 67 , 68 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8MidTipo" );
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(0),"Todas");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) cmbavMidtipo.getGXComponent()).addItem( new java.lang.Short(4),"Box");
         cmbavMidtipo.addFocusListener(this);
         cmbavMidtipo.addItemListener(this);
         cmbavMidtipo.getGXComponent().setHelpId("HLP_WConfTipMidia.htm");
         edtavCatnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),312, 67, 182, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 312 , 67 , 182 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV10CatNom" );
         ((GXEdit) edtavCatnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavCatnome.addFocusListener(this);
         edtavCatnome.getGXComponent().setHelpId("HLP_WConfTipMidia.htm");
         addSubfile ( subGxsf2  = new GXSubfile ( new ConfTipMidia_load02(this), new ConfTipMidia_flow02(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 176, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 175 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A32CatCodi" ), "Código da categoria do filme"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 175 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , false )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 307, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 306 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A33CatNome" ), "Categoria"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 306 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 104 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A35MidTipo" ), "Formato"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 104 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),0, 0, 122, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 121 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV7ConfTip" ), "Valor (R$)"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 121 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),0, 0, 106, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 105 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6ConfTip" ), "Novo valor (R$)"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 105 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXCheckBox(GXPanel1, "" , "S", "N") , null ,  0 , 0 , 58 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5Marcado" ), "Marcado"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 58 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         }, 15 , 18 , GXPanel1 , 65 , 104 , 755 , 299 ,  18 ));
         ((GXComboBox) subGxsf2.getColumn(2).getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) subGxsf2.getColumn(2).getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) subGxsf2.getColumn(2).getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) subGxsf2.getColumn(2).getGXComponent()).addItem( new java.lang.Short(4),"Box");
         subGxsf2.addActionListener(this);
         subGxsf2.addFocusListener(this);
         subGxsf2.setSortOnClick(true);
         bttbtt16 = UIFactory.getGXButton( GXPanel1 , "Novo" ,  715 ,  65 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt16.setTooltip("Novo");
         bttbtt16.addActionListener(this);
         bttbtt16.setFiresEvents(false);
         bttbtt9 = UIFactory.getGXButton( GXPanel1 , "M" ,  65 ,  416 ,  26 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt9.setTooltip("M");
         bttbtt9.addActionListener(this);
         bttbtt9.setFiresEvents(false);
         bttbtt10 = UIFactory.getGXButton( GXPanel1 , "D" ,  104 ,  416 ,  26 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt10.setTooltip("D");
         bttbtt10.addActionListener(this);
         bttbtt10.setFiresEvents(false);
         bttbtt11 = UIFactory.getGXButton( GXPanel1 , "Gravar" ,  728 ,  416 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt11.setTooltip("Gravar");
         bttbtt11.addActionListener(this);
         bttbtt11.setFiresEvents(false);
         lbllbl13 = UIFactory.getLabel(GXPanel1, "Configurações tipo de mídia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 160 , 13 );
         lbllbl12 = UIFactory.getLabel(GXPanel1, "Tipo de mídia:", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 71 , 83 , 13 );
         lbllbl15 = UIFactory.getLabel(GXPanel1, "Categoria:", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 247 , 71 , 59 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   cmbavMidtipo ,
                   edtavCatnome ,
                   subGxsf2 ,
                   bttbtt16 ,
                   bttbtt9 ,
                   bttbtt10 ,
                   bttbtt11
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf2, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile02( )
      {
         subwconftipmidia02.setCatCodigo(A32CatCodi);
         subwconftipmidia02.setCatNome(A33CatNome);
         subwconftipmidia02.setMidTipo(A35MidTipo);
         subwconftipmidia02.setVConfTipValor(AV7ConfTip);
         subwconftipmidia02.setVConfTipValNovo(AV6ConfTip);
         subwconftipmidia02.setVMarcado(AV5Marcado);
      }

      protected void subfileToVariables02( )
      {
         A32CatCodi = subwconftipmidia02.getCatCodigo();
         A33CatNome = subwconftipmidia02.getCatNome();
         A35MidTipo = subwconftipmidia02.getMidTipo();
         AV7ConfTip = subwconftipmidia02.getVConfTipValor();
         AV6ConfTip = subwconftipmidia02.getVConfTipValNovo();
         AV5Marcado = subwconftipmidia02.getVMarcado();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         cmbavMidtipo.setValue( AV8MidTipo );
         edtavCatnome.setValue( AV10CatNom );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV8MidTipo = (short)(cmbavMidtipo.getValue()) ;
         cmbavMidtipo.setValue(AV8MidTipo);
         AV10CatNom = (String)(edtavCatnome.getValue()) ;
         edtavCatnome.setValue(AV10CatNom);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf2.inValidElement() )
         {
            subwconftipmidia02 = ( subwconftipmidia02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwconftipmidia02 = new subwconftipmidia02 ();
         }
         subfileToVariables02 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile02 ();
         subGxsf2.refreshLineValue(subwconftipmidia02);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf2.inValidElement() )
         {
            subwconftipmidia02 = ( subwconftipmidia02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwconftipmidia02 = new subwconftipmidia02 ();
         }
         subfileToVariables02 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttbtt9.isEventSource(eventSource) ) {
            /* Execute user event: E12V1U2 */
            E12V1U2 ();
            return;
         }
         if ( bttbtt10.isEventSource(eventSource) ) {
            /* Execute user event: E13V1U2 */
            E13V1U2 ();
            return;
         }
         if ( bttbtt11.isEventSource(eventSource) ) {
            /* Execute user event: E15V1U2 */
            E15V1U2 ();
            return;
         }
         if ( bttbtt16.isEventSource(eventSource) ) {
            /* Execute user event: E14V1U2 */
            E14V1U2 ();
            return;
         }
         if ( subGxsf2.isEventSource(eventSource) ) {
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( cmbavMidtipo.isEventSource(eventSource) ) {
            setGXCursor( cmbavMidtipo.getGXCursor() );
            return;
         }
         if ( edtavCatnome.isEventSource(eventSource) ) {
            setGXCursor( edtavCatnome.getGXCursor() );
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
         if ( cmbavMidtipo.isEventSource(eventSource) ) {
            AV8MidTipo = cmbavMidtipo.getValue() ;
            return;
         }
         if ( edtavCatnome.isEventSource(eventSource) ) {
            AV10CatNom = edtavCatnome.getValue() ;
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
         subwconftipmidia02 = new subwconftipmidia02();
         scmdbuf = "" ;
         AV8MidTipo = 0 ;
         AV10CatNom = "" ;
         A35MidTipo = 0 ;
         A33CatNome = "" ;
         W001U2_A85ConfTip = new decimal[1] ;
         W001U2_n85ConfTip = new bool[] {false} ;
         W001U2_A35MidTipo = new short[1] ;
         W001U2_A33CatNome = new String[] {""} ;
         W001U2_n33CatNome = new bool[] {false} ;
         W001U2_A32CatCodi = new int[1] ;
         A85ConfTip = (decimal)(0M) ;
         n85ConfTip = false ;
         n33CatNome = false ;
         A32CatCodi = 0 ;
         gxIsRefreshing = false ;
         AV6ConfTip = (decimal)(0M) ;
         AV5Marcado = "" ;
         AV7ConfTip = (decimal)(0M) ;
         AV8MidTipo = 0 ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wconftipmidia__default(),
            new Object[][] {
                new Object[] {
               W001U2_A85ConfTip, W001U2_n85ConfTip, W001U2_A35MidTipo, W001U2_A33CatNome, W001U2_n33CatNome, W001U2_A32CatCodi
               }
            }
         );
         reloadDynamicLists(0);
         AV8MidTipo = 0 ;
         cmbavMidtipo.setValue(AV8MidTipo);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV8MidTipo ;
      protected short A35MidTipo ;
      protected int A32CatCodi ;
      protected decimal A85ConfTip ;
      protected decimal AV6ConfTip ;
      protected decimal AV7ConfTip ;
      protected String scmdbuf ;
      protected String AV5Marcado ;
      protected bool n85ConfTip ;
      protected bool n33CatNome ;
      protected bool gxIsRefreshing ;
      protected String AV10CatNom ;
      protected String A33CatNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwconftipmidia02 subwconftipmidia02 ;
      protected IDataReader W001U2 ;
      protected IDataStoreProvider pr_default ;
      protected decimal[] W001U2_A85ConfTip ;
      protected bool[] W001U2_n85ConfTip ;
      protected short[] W001U2_A35MidTipo ;
      protected String[] W001U2_A33CatNome ;
      protected bool[] W001U2_n33CatNome ;
      protected int[] W001U2_A32CatCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectShort cmbavMidtipo ;
      protected GUIObjectString edtavCatnome ;
      protected GXSubfile subGxsf2 ;
      protected IGXButton bttbtt16 ;
      protected IGXButton bttbtt9 ;
      protected IGXButton bttbtt10 ;
      protected IGXButton bttbtt11 ;
      protected ILabel lbllbl13 ;
      protected ILabel lbllbl12 ;
      protected ILabel lbllbl15 ;
   }

   public class wconftipmidia__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W001U2( short AV8MidTipo ,
                                           String AV10CatNom ,
                                           short A35MidTipo ,
                                           String A33CatNome )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT T1.[ConfTipValor], T1.[MidTipo], T2.[CatNome], T1.[CatCodigo] FROM ([CONFTIPMIDIA] T1 WITH (NOLOCK) INNER JOIN [CATEGORIA] T2 WITH (NOLOCK) ON T2.[CatCodigo] = T1.[CatCodigo])" ;
         sWhereString = "" ;
         if ( ( AV8MidTipo != 0 ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[MidTipo] = " + StringUtil.Str( (decimal)(AV8MidTipo), 1, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[MidTipo] = " + StringUtil.Str( (decimal)(AV8MidTipo), 1, 0) + ")" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV10CatNom).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T2.[CatNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV10CatNom, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " (T2.[CatNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV10CatNom, "'", "''")), 50, "%") + "')" ;
            }
         }
         if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[MidTipo], T1.[CatCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W001U2( (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

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
          Object[] prmW001U2 ;
          prmW001U2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W001U2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW001U2,13,0,true,false )
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
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
