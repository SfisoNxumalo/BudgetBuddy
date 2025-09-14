import styles from './ListItemStyles.module.css'


export default function ListItemBig()
{
    return(
        <div className={styles.holder}>
            <div className={styles.Top}>
                <h5>Your stay with us</h5>
            </div>
            
            <div className={styles.Middle}>

                <div className={styles.itemDetails}>
                    <p>View full booking details</p>
                </div>

                <div className={styles.itemImage}>
                    <img src={"https://hbr.org/resources/images/article_assets/2022/11/1122_21_Finance_1360192291_v2.pg_.jpg"} />
                </div>
            </div>

            <div className={styles.Bottom}>
                <div className={styles.Checks}>
                    <label className={styles.lblChecks}>Check-in</label>
                    <label className={styles.lblChecksDate}>Fri 11 Apr</label>
                    <label className={styles.lblChecksTime}>10:00</label>
                </div>
                <hr/>
                {/* <div className={styles.CheckDivider}>

                </div> */}
                <div className={styles.Checks}>
                    <label className={styles.lblChecks}>Check-out</label>
                    <label className={styles.lblChecksDate}>Sun 13 Apr</label>
                    <label className={styles.lblChecksTime}>15:00</label>
                </div>

            </div>
            

        </div>
    );
}