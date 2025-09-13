import { Stack } from "@mantine/core";
import SingleUser from "./Components/SingleUser";

export default function ViewUsersPage(){

    return(
         <Stack
              h={300}
              bg="var(--mantine-color-body)"
              align="stretch"
              justify="center"
              gap="md"
            >
                <SingleUser />
            </Stack>
    );
}