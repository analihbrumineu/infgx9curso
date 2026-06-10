/*
               File: ConsFilme
        Description: Consulta de filmes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:18:14.5
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
   public class wconsfilme : GXWorkpanel
   {
      public wconsfilme( int hnd ,
                         ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wconsfilme( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wconsfilme( IGxContext context ,
                         int hnd ,
                         ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "ConsFilme" ;
      }

      public override String getFrmTitle( )
      {
         return "Consulta de filmes." ;
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
         return 858 ;
      }

      public override int getFrmHeight( )
      {
         return 780 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WConsFilme.htm";
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

      public void execute( out int aP0_FilCodigoRet )
      {
         this.AV9FilCodi = 0 ;
         executePrivate();
         aP0_FilCodigoRet=this.AV9FilCodi;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load08( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwconsfilme08 = new subwconsfilme08 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV5FilCodi ,
                                              AV7FilNome ,
                                              AV6FilData ,
                                              A28FilCodi ,
                                              A29FilNome ,
                                              A31FilData },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W000M2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf8.getSize() < 10000 ) ) )
         {
            A34FilDesc = W000M2_A34FilDesc[0] ;
            n34FilDesc = W000M2_n34FilDesc[0] ;
            A31FilData = W000M2_A31FilData[0] ;
            n31FilData = W000M2_n31FilData[0] ;
            A30FilSitu = W000M2_A30FilSitu[0] ;
            n30FilSitu = W000M2_n30FilSitu[0] ;
            A29FilNome = W000M2_A29FilNome[0] ;
            n29FilNome = W000M2_n29FilNome[0] ;
            A28FilCodi = W000M2_A28FilCodi[0] ;
            /* Execute user event: E11V0M2 */
            E11V0M2 ();
            pr_default.readNext(0);
         }
         if ( subGxsf8.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class ConsFilme_load08 : GXLoadProducer
      {
         wconsfilme _sf ;

         public ConsFilme_load08( wconsfilme uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer08();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load08();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors08();
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
            subGxsf8.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow08( )
      {
         return true;
      }

      public void autoRefresh_flow08( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow08() )) {
            subfile.refresh();
            resetSubfileConditions_flow08() ;
         }
      }

      public bool getSearch_flow08( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow08( )
      {
      }

      public void resetSearchConditions_flow08( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow08( )
      {
         return new subwconsfilme08 ();
      }

      public bool getSearch_flow08( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow08( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow08( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow08( )
      {
         GXRefreshCommand08 ();
      }

      public class ConsFilme_flow08 : GXSubfileFlow
      {
         wconsfilme _sf ;

         public ConsFilme_flow08( wconsfilme uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow08();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow08(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow08();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow08();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow08(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow08();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow08(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow08(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow08(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow08();
         }

      }

      protected void GXRefreshCommand08( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public override void GXExit( )
      {
         /* Execute user event: E12V0M2 */
         E12V0M2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
            }
            if (true) return;
         }
      }

      protected void E12V0M2( )
      {
         eventLevelContext();
         /* Exit Routine */
         AV9FilCodi = A28FilCodi ;
      }

      protected void E13V0M2( )
      {
         eventLevelContext();
         /* FilCodigo_Click Routine */
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
      }

      protected void E14V0M2( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("A28FilCodi") )
         {
            new wconsfilme(context, base.remoteHandle, base.context).execute( out  A28FilCodi) ;
            ((subwconsfilme08)subGxsf8.getCurrentElement()).setFilCodigo(A28FilCodi);
            subGxsf8.refreshLineValue(subGxsf8.getSelectedElement());
            subGxsf8.repaint();
         }
         eventLevelResetContext();
      }

      public void loadToBuffer08( )
      {
         subwconsfilme08 oAux = subwconsfilme08 ;
         subwconsfilme08 = new subwconsfilme08 ();
         variablesToSubfile08 ();
         subGxsf8.addElement(subwconsfilme08);
         subwconsfilme08 = oAux;
      }

      private void E11V0M2( )
      {
         /* Load Routine */
         subGxsf8.loadCommand();
      }

      protected void closeCursors08( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 858 , 780 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavFilcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),65, 78, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 65 , 78 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5FilCodi" );
         ((GXEdit) edtavFilcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavFilcodigo.addFocusListener(this);
         edtavFilcodigo.getGXComponent().setHelpId("HLP_WConsFilme.htm");
         edtavFilnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),156, 78, 533, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 156 , 78 , 533 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7FilNome" );
         ((GXEdit) edtavFilnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavFilnome.addFocusListener(this);
         edtavFilnome.getGXComponent().setHelpId("HLP_WConsFilme.htm");
         edtavFildata = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),715, 78, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 715 , 78 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6FilData" );
         ((GXEdit) edtavFildata.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavFildata.addFocusListener(this);
         edtavFildata.getGXComponent().setHelpId("HLP_WConsFilme.htm");
         addSubfile ( subGxsf8  = new GXSubfile ( new ConsFilme_load08(this), new ConsFilme_flow08(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 53, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 52 , 18 , UIFactory.getColor(5) , UIFactory.getColor(255, 0, 0) , UIFactory.getFont( "Courier New", 0, 9) , false , "A28FilCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 52 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 260, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 259 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A29FilNome" ), "Nome do filme"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 259 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 73 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A30FilSitu" ), "Situação"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 73 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),0, 0, 68, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.DATE, false, false, 0, false) , null ,  0 , 0 , 67 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A31FilData" ), "Estreia"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 67 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , false )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(800, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 285, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.LONGVARCHAR, false, false, 0, false) , null ,  0 , 0 , 284 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A34FilDesc" ), "Descrição"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 284 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 35 , 18 , GXPanel1 , 65 , 104 , 728 , 663 ,  18 ));
         ((GXComboBox) subGxsf8.getColumn(2).getGXComponent()).addItem( new java.lang.Short(1),"Ativo");
         ((GXComboBox) subGxsf8.getColumn(2).getGXComponent()).addItem( new java.lang.Short(0),"Inativo");
         subGxsf8.addActionListener(this);
         subGxsf8.addFocusListener(this);
         subGxsf8.setSortOnClick(true);
         subGxsf8.getColumn(0).addActionListener( this);
         subGxsf8.getColumn(0).addItemListener( this);
         lbllbl14 = UIFactory.getLabel(GXPanel1, "Consulta de filmes", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 104 , 13 );
         lbllbl3 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 65 , 40 , 13 );
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Nome do filme", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 156 , 65 , 81 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "Estreia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 715 , 65 , 40 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavFilcodigo ,
                   edtavFilnome ,
                   edtavFildata ,
                   subGxsf8
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf8, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile08( )
      {
         subwconsfilme08.setFilCodigo(A28FilCodi);
         subwconsfilme08.setFilNome(A29FilNome);
         subwconsfilme08.setFilSituacao(A30FilSitu);
         subwconsfilme08.setFilData(A31FilData);
         subwconsfilme08.setFilDescricao(A34FilDesc);
      }

      protected void subfileToVariables08( )
      {
         A28FilCodi = subwconsfilme08.getFilCodigo();
         A29FilNome = subwconsfilme08.getFilNome();
         A30FilSitu = subwconsfilme08.getFilSituacao();
         A31FilData = subwconsfilme08.getFilData();
         A34FilDesc = subwconsfilme08.getFilDescricao();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavFilcodigo.setValue( AV5FilCodi );
         edtavFilnome.setValue( AV7FilNome );
         edtavFildata.setValue( AV6FilData );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5FilCodi = (int)(edtavFilcodigo.getValue()) ;
         edtavFilcodigo.setValue(AV5FilCodi);
         AV7FilNome = (String)(edtavFilnome.getValue()) ;
         edtavFilnome.setValue(AV7FilNome);
         AV6FilData = (DateTime)(edtavFildata.getValue()) ;
         edtavFildata.setValue(AV6FilData);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf8.inValidElement() )
         {
            subwconsfilme08 = ( subwconsfilme08 ) subGxsf8.getCurrentElement() ;
         }
         else
         {
            subwconsfilme08 = new subwconsfilme08 ();
         }
         subfileToVariables08 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile08 ();
         subGxsf8.refreshLineValue(subwconsfilme08);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf8.inValidElement() )
         {
            subwconsfilme08 = ( subwconsfilme08 ) subGxsf8.getCurrentElement() ;
         }
         else
         {
            subwconsfilme08 = new subwconsfilme08 ();
         }
         subfileToVariables08 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( subGxsf8.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf8.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E13V0M2 */
            E13V0M2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavFilcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavFilcodigo.getGXCursor() );
            return;
         }
         if ( edtavFilnome.isEventSource(eventSource) ) {
            setGXCursor( edtavFilnome.getGXCursor() );
            return;
         }
         if ( edtavFildata.isEventSource(eventSource) ) {
            setGXCursor( edtavFildata.getGXCursor() );
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
         if ( edtavFilcodigo.isEventSource(eventSource) ) {
            AV5FilCodi = edtavFilcodigo.getValue() ;
            return;
         }
         if ( edtavFilnome.isEventSource(eventSource) ) {
            AV7FilNome = edtavFilnome.getValue() ;
            return;
         }
         if ( edtavFildata.isEventSource(eventSource) ) {
            AV6FilData = edtavFildata.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf8.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E13V0M2 */
            E13V0M2 ();
            return;
         }
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (keyCode == UIFactory.getKeyCodes().getF4()) {
            /* Execute user event: E14V0M2 */
            E14V0M2 ();
            return true ;
         }
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
            /* Execute user event: E12V0M2 */
            E12V0M2 ();
         }
         this.AV9FilCodi = AV9FilCodi;
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
         subwconsfilme08 = new subwconsfilme08();
         scmdbuf = "" ;
         AV5FilCodi = 0 ;
         AV7FilNome = "" ;
         AV6FilData = (DateTime)(DateTime.MinValue) ;
         A28FilCodi = 0 ;
         A29FilNome = "" ;
         A31FilData = (DateTime)(DateTime.MinValue) ;
         W000M2_A34FilDesc = new String[] {""} ;
         W000M2_n34FilDesc = new bool[] {false} ;
         W000M2_A31FilData = new DateTime[] {DateTime.MinValue} ;
         W000M2_n31FilData = new bool[] {false} ;
         W000M2_A30FilSitu = new short[1] ;
         W000M2_n30FilSitu = new bool[] {false} ;
         W000M2_A29FilNome = new String[] {""} ;
         W000M2_n29FilNome = new bool[] {false} ;
         W000M2_A28FilCodi = new int[1] ;
         A34FilDesc = "" ;
         n34FilDesc = false ;
         n31FilData = false ;
         A30FilSitu = 0 ;
         n30FilSitu = false ;
         n29FilNome = false ;
         gxIsRefreshing = false ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wconsfilme__default(),
            new Object[][] {
                new Object[] {
               W000M2_A34FilDesc, W000M2_n34FilDesc, W000M2_A31FilData, W000M2_n31FilData, W000M2_A30FilSitu, W000M2_n30FilSitu, W000M2_A29FilNome, W000M2_n29FilNome, W000M2_A28FilCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short A30FilSitu ;
      protected int AV5FilCodi ;
      protected int A28FilCodi ;
      protected int AV9FilCodi ;
      protected String scmdbuf ;
      protected DateTime AV6FilData ;
      protected DateTime A31FilData ;
      protected bool n34FilDesc ;
      protected bool n31FilData ;
      protected bool n30FilSitu ;
      protected bool n29FilNome ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected String A34FilDesc ;
      protected String AV7FilNome ;
      protected String A29FilNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwconsfilme08 subwconsfilme08 ;
      protected IDataReader W000M2 ;
      protected IDataStoreProvider pr_default ;
      protected String[] W000M2_A34FilDesc ;
      protected bool[] W000M2_n34FilDesc ;
      protected DateTime[] W000M2_A31FilData ;
      protected bool[] W000M2_n31FilData ;
      protected short[] W000M2_A30FilSitu ;
      protected bool[] W000M2_n30FilSitu ;
      protected String[] W000M2_A29FilNome ;
      protected bool[] W000M2_n29FilNome ;
      protected int[] W000M2_A28FilCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavFilcodigo ;
      protected GUIObjectString edtavFilnome ;
      protected GUIObjectDatetime edtavFildata ;
      protected GXSubfile subGxsf8 ;
      protected ILabel lbllbl14 ;
      protected ILabel lbllbl3 ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl6 ;
      protected int aP0_FilCodigoRet ;
   }

   public class wconsfilme__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W000M2( int AV5FilCodi ,
                                           String AV7FilNome ,
                                           DateTime AV6FilData ,
                                           int A28FilCodi ,
                                           String A29FilNome ,
                                           DateTime A31FilData )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [FilDescricao], [FilData], [FilSituacao], [FilNome], [FilCodigo] FROM [FILME] WITH (NOLOCK)" ;
         sWhereString = "" ;
         if ( ( AV5FilCodi != 0 ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([FilCodigo] = " + StringUtil.Str( (decimal)(AV5FilCodi), 9, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " ([FilCodigo] = " + StringUtil.Str( (decimal)(AV5FilCodi), 9, 0) + ")" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV7FilNome).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([FilNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV7FilNome, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " ([FilNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV7FilNome, "'", "''")), 50, "%") + "')" ;
            }
         }
         if ( ( AV6FilData != DateTimeUtil.CToD( "0", 2) ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([FilData] = " + ((AV6FilData>DateTimeUtil.CToD( "01/01/1753", 3)) ? "convert( DATETIME,'"+DateTimeUtil.DToC( AV6FilData, 0, "-")+"',102)" : "convert( DATETIME, '17530101', 112 )") + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " ([FilData] = " + ((AV6FilData>DateTimeUtil.CToD( "01/01/1753", 3)) ? "convert( DATETIME,'"+DateTimeUtil.DToC( AV6FilData, 0, "-")+"',102)" : "convert( DATETIME, '17530101', 112 )") + ")" ;
            }
         }
         if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY [FilCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W000M2( (int)dynConstraints[0] , (String)dynConstraints[1] , (DateTime)dynConstraints[2] , (int)dynConstraints[3] , (String)dynConstraints[4] , (DateTime)dynConstraints[5] );
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
          Object[] prmW000M2 ;
          prmW000M2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000M2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000M2,28,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getLongVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((int[]) buf[8])[0] = rslt.getInt(5) ;
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
