import AdCard from "./Components/AdCard";
import styles from './styles/DashboardStyles.module.css'
import * as React from 'react';
import useScrollTrigger from '@mui/material/useScrollTrigger';
import Slide from '@mui/material/Slide';
import ListItemSmall from './Components/ListItemSmall/ListItemSmall';
import ListItemBig from './Components/ListItemBig/ListItemBig';
import ListItemXSmall from './Components/ListItemXSmall/ListItemXSmall';
// import { bellImg, dashIma, messageImg, rateImg } from '../../../assets/imageStore';
import ServiceCarousel from './Components/ServiceCarousel/ServiceCarousel';
import AppBar from '@mui/material/AppBar';
import Toolbar from '@mui/material/Toolbar';
import CssBaseline from '@mui/material/CssBaseline';
import Box from '@mui/material/Box';
import Container from '@mui/material/Container';
import Avatar from '@mui/material/Avatar';
import { deepOrange, deepPurple } from '@mui/material/colors';
import Badge, { type BadgeProps } from '@mui/material/Badge';
import { styled } from '@mui/material/styles';
import IconButton from '@mui/material/IconButton';
import ShoppingCartIcon from '@mui/icons-material/ShoppingCart';
import NotificationsIcon from '@mui/icons-material/Notifications';
import { Link, useNavigate } from 'react-router-dom';
import RateDialog from './Components/RateDialog/RateDialog';
import { useState } from 'react';
import { CategoryBudgets } from "./Components/CategoryItem/Categorybudget";

interface Props {
  /**
   * Injected by the documentation to work in an iframe.
   * You won't need it on your project.
   */
  window?: () => Window;
  children?: React.ReactElement<unknown>;
}


  function HideOnScroll(props: Props) {
    const { children, window } = props;
    // Note that you normally won't need to set the window ref as useScrollTrigger
    // will default to window.
    // This is only being set here because the demo is in an iframe.
    const trigger = useScrollTrigger({
      target: window ? window() : undefined,
    });

  
    return (
      <Slide appear={false} direction="down" in={!trigger}>
        {children ?? <div />}
      </Slide>
    );
  }

  const StyledBadge = styled(Badge)<BadgeProps>(({ theme }) => ({
    '& .MuiBadge-badge': {
      right: 0,
      top: 0,
      border: `2px solid var(--app-color)`,
      padding: '0 4px',
    },
  }));
  
  function Compo(props: Props){
    const dashIma = "https://hbr.org/resources/images/article_assets/2022/11/1122_21_Finance_1360192291_v2.pg_.jpg"
    return(
      <React.Fragment >
                      <CssBaseline />
                      <HideOnScroll  {...props} >
                        <AppBar sx={{ backgroundColor: 'transparent', 
                                      boxShadow: 'none'
                                        }}> 
                          <Toolbar>
                            <div className={styles.MainDetailsHolder}>
                                <div className={styles.holder} style={{height:'150px'}}>
                                  <div  className={styles.holderItems}>
                                    <div className={styles.holderItems} style={{width:'100%', display: 'flex'}}>
                                    <Avatar sx={{ bgcolor: deepOrange[500] }}>N</Avatar>
                                    <label> Hello Sfiso</label>
                                  </div>
                                  <IconButton sx={{color:'white'}} aria-label="cart">
                                    <StyledBadge badgeContent={1} color="error">
                                      <NotificationsIcon sx={{ fontSize: 20 }} />
                                    </StyledBadge>
                                  </IconButton>
                                  <IconButton  aria-label="cart">
                                    <StyledBadge badgeContent={1} sx={{color:'white'}} color="secondary">
                                      <ShoppingCartIcon sx={{ fontSize: 20 }} />
                                    </StyledBadge>
                                  </IconButton>
                                  </div>
                                  <div className={styles.sthombeHolder}>
                                  <img className={styles.sthombe} src={dashIma}/>
                                </div>
                                </div>
                            </div>
                            
                          </Toolbar>
                        </AppBar>
                      </HideOnScroll>
                      <Toolbar />
                      <Container>
                        <Box sx={{ my: 2 }}>
                          {/* {[...new Array(12)]
                            .map(
                              () => `Cras mattis consectetur purus sit amet fermentum.
                Cras justo odio, dapibus ac facilisis in, egestas eget quam.
                Morbi leo risus, porta ac consectetur ac, vestibulum at eros.
                Praesent commodo cursus magna, vel scelerisque nisl consectetur et.`,
                            )
                            .join('\n')} */}
                        </Box>
                      </Container>
                    </React.Fragment>
    )
  }

export default function UserDashboardPage(){
    const navigate = useNavigate();
   const [open, setOpen] = useState(false);
const dashIma = "https://hbr.org/resources/images/article_assets/2022/11/1122_21_Finance_1360192291_v2.pg_.jpg"
   const closeDialog = ()=> {
      setOpen(false)
   }
    return(
        <>
        <section style={styles}>
           <div className={styles.topContainer}></div>
           <div className={styles.bottomContainer}></div>
           <div className={styles.overDiv}>
                <div className={styles.mainContainer}>
                    {/* <div className={styles.mainContainerTop}> */}
                    {/* <Compo/> */}
                    {/* </div> */}
                    <div className={styles.mainContainerBottom}> <AdCard/>
                        <h4>Your Categories</h4>
                        <CategoryBudgets/>
                    </div>
                </div>
           </div>
        </section>
        </>
        
    )
}