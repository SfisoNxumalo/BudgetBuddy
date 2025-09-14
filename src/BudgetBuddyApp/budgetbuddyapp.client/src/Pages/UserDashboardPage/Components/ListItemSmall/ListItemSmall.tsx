import { Progress } from '@mantine/core';
import styles from './ListItemStyles.module.css'
import { useNavigate } from 'react-router-dom';

export default function ListItemSmall()
{
    const image = 'https://hbr.org/resources/images/article_assets/2022/11/1122_21_Finance_1360192291_v2.pg_.jpg'
    const navigate = useNavigate();
    return(
        <>

        <div onClick={()=> {navigate('/room-service')}} className={styles.holder}>
            <div className={styles.itemDetails}>
                {/* <h5>Room Service</h5> */}
                 <p>Food</p>
                
            </div>
            <div className={styles.itemImage}>
                <img src={image} />
            </div>

        </div>
         <Progress value={60} color="orange" size="xl" orientation="horizontal" h={10} animated />
        </>
        
    );
}